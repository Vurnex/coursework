# This code is to optimize the linear regression model.

import pandas as pd
import numpy as np
from pandas import DataFrame
from sklearn import preprocessing                                           #self import
from sklearn import datasets, svm                                           #self import
from matplotlib import pyplot as plt
from sklearn import linear_model
from sklearn.preprocessing import scale
from sklearn.model_selection import train_test_split, cross_val_score
from sklearn.linear_model import LinearRegression
from sklearn.linear_model import Ridge, RidgeCV, Lasso, LassoCV
from sklearn.metrics import mean_squared_error, accuracy_score
from sklearn.model_selection import KFold

# Read the data from "data-Lab10.csv" using dataFrame
# Use column names of ["ReT", "In_v", "Tar", "Gas","Char","Out_T"]
# Normalize the values in the range of (a , b) where a = 1 and b = 3

''' Your Code Here '''

dataset = pd.read_csv(r'C:\Users\User\PycharmProjects\lab10\data-Lab10.csv')

dataset.columns = ['ReT', 'In_v', 'Tar', 'Gas', 'Char', 'Out_T']

#print(dataset.head())

# Normalizing the dataset using MinMaxScaler
scaler = preprocessing.MinMaxScaler(feature_range=(1, 3))
scaleByReT = dataset.columns
d = scaler.fit_transform(dataset)
scaled_df = pd.DataFrame(d, columns=scaleByReT)

#print(scaled_df)

# --------Functions---------------------------------------------------------------------
def calc_error(X_train, Y_train, model):
    # Find the prediction using predict method in model
	# Compute and return the MSE (mean square error) of y and prediction

    # Your Code Here

    # Returns the error for an already fit model
    predictions = model.predict(X_train)
    newMSE = mean_squared_error(Y_train, predictions)
    return newMSE

def modelfit_error(X_train, y_train, X_test, y_test, model):
    # First fit the model using fit method
    # Compute and return the MSE errors for train and test data set
    # (train_error and Validation error)
    # Hint: use "calc_error function

    # Your Code Here

    # Fit the model to the input training data

    # Fit the model and return the MSE for sample error and out of sample error
    model.fit(X_train, y_train)
    trainError = calc_error(X_train, y_train, model)
    validationError = calc_validation_error(X_test, y_test, model)
    return trainError, validationError

def calc_validation_error(X_test, y_test, model):

    # Return the out of sample error for an already fit model
    predictions = model.predict(X_test)

    newMSE = mean_squared_error(y_test, predictions)

    return newMSE

# --------End of Functions---------------------------------------------------------------

# Select X and Y
x = scaled_df[['ReT', 'In_v']]
y = scaled_df['Out_T']

# Splitting the dataset into 80% training data and 20% testing data.
X_train, X_test, Y_train, Y_test = train_test_split(x, y, test_size=.20, random_state=15)

# Linear Regression. Build the model.
lr = LinearRegression(fit_intercept=True)
train_error, test_error = modelfit_error(X_train, Y_train, X_test, Y_test, lr)
train_error, test_error = round(train_error, 3), round(test_error, 3)

# Intermediate/test split (Temporary variables that gives us test set)
X_intermediate, X_test, y_intermediate, y_test = train_test_split(x, y, shuffle=True, test_size=0.2,
                                                                  random_state=15)
# Train/validation split (Gives us the train and validation sets)
X_train, X_validation, y_train, y_validation = train_test_split(X_intermediate, y_intermediate, shuffle=False,
                                                                test_size=0.25, random_state=2018)
# Delete the intermediate variables as they are no longer needed
del X_intermediate, y_intermediate

# Print proportions / check fitting
print('train: {}% | validation: {}% | test {}%'.format(round(len(y_train)/len(y), 2),
                                                       round(len(y_validation)/len(y), 2),
                                                       round(len(y_test)/len(y), 2)))

print('train error: {} | test error: {}'.format(train_error, test_error))
print('train/test: {}'.format(round(test_error/train_error, 1)))

#Initiate alphas
alphas = [1e-7, 1e-6, 1e-5, 1e-4, 1e-3, 1e-2, 1e-1, 1, 1e1]
print('-'*76)
print('RMSE errors')
print('-'*76)   # For separating sections, making the output easier to read.
for alpha in alphas:

    # Using Ridge, instantiate and fit the model
    ridge = Ridge(alpha=alpha, fit_intercept=True, random_state=99)
    ridge.fit(X_train, y_train)

    # Calculate the errors
    new_train_error = mean_squared_error(y_train, ridge.predict(X_train))
    new_validation_error = mean_squared_error(y_validation, ridge.predict(X_validation))
    new_test_error = mean_squared_error(y_test, ridge.predict(X_test))

    # Write report
    print('alpha: {:7} | train error: {:5} | val error: {:6} | test error: {}'.
          format(alpha,
                 round(new_train_error, 3),
                 round(new_validation_error, 3),
                 round(new_test_error, 3)))

# Cross Val
print('-'*76)

# Store val errors
val_errors = []
for alpha in alphas:
    # Using lasso, build the model for cross value scores
    lasso = Lasso(alpha=alpha, fit_intercept=True, random_state=77)
    errors = np.sum(-cross_val_score(lasso, x, y, scoring='neg_mean_squared_error', cv=10, n_jobs=-1))
    val_errors.append(np.sqrt(errors))

print('Best alpha: {}'.format(alphas[np.argmin(val_errors)]))

# K Fold
print('-'*76)
print('K Fold')
print('-'*76)

K = 5   # Number of folds
kf = KFold(n_splits=K, shuffle=True, random_state=42)   # Define the split into 5 folds
kf.get_n_splits(x)  # Returns the number of splitting iterations in the cross-validator

for alpha in alphas:
    train_errors = []
    validation_errors = []

    for train_index, val_index in kf.split(x, y):
        # Split data set into x_train, x_val, y_train, y_val
        # Use following link for usage of KFold
        # https://scikit-learn.org/stable/modules/generated/sklearn.model_selection.KFold.html

        #Your Code here

        # Split the data
        X_train, X_val = x.iloc[train_index], x.iloc[val_index]
        y_train, y_val = y.iloc[train_index], y.iloc[val_index]

        # Linear Regression
        lmodel = Lasso(alpha=alpha, fit_intercept=True, random_state=77)

        # Calculate errors using "modelfit_error" function
        train_error, val_error = modelfit_error(X_train, y_train, X_val, y_val, lmodel)

        # Append train and validation errors to errors of previous Folds

        # Your Code here
        train_errors.append(train_error)
        validation_errors.append(val_error)

    # Following code will display mean MSE errors for each alpha
    # You may need to change variable name "train_errors" and "validation_errors" in following code
    # Use your variable names

    # Write Report
    print('alpha: {:6} | mean(train_error): {:7} | mean(val_error): {}'.
          format(alpha,
                 round(np.mean(train_errors), 4),
                 round(np.mean(validation_errors), 4)))

# Plot the data.

x1 = np.linspace(0, 1, 5)
x2 = np.linspace(0, 1, 5)

# Line 1 points
plt.plot(x1, train_errors)

# Line 1 points
plt.plot(x2, validation_errors)

# naming the x axis
plt.xlabel('Alpha')
# naming the y axis
plt.ylabel('Train/Val Errors')
# giving a title to my graph
plt.title('New Graph')

plt.show()
