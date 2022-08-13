import numpy as np

#load the data from the text file into the variable
data = np.loadtxt('lab2-data.txt', delimiter = "	")

#set x with the data from the first list in the file
x = data[:, 0]

#set y with the data from the second list in the file
y = data[:, 1]

#print(x) 
#for testing purposes
#print(y)

#function for the process of calculating the linear regression equation
def linearRegression(x, y):
    #get number of observations from the dataset and set it to the N variable
    N = len(x)

    #calculate the mean for x and y using numpy's mean function
    xMean = np.mean(x)
    yMean = np.mean(y)

    #print(x_mean)
    #for testing purposes
    #print(y_mean)
    
    #linear regression operations
    #calculate slope of b1 using the b1 numerator and denominator as well as numpy's sum function
    b1Numerator = np.sum((x - xMean) * (y - yMean))
    b1Denominator = np.sum((x - xMean)**2)
    b1 = b1Numerator / b1Denominator

    #using b1 and the mean of x and y, calculate the intercept b0
    b0 = yMean - (b1 * xMean)
    
    #print results for question 1
    print("Question 1")

    print("b0: ", b0)
    print("b1: ", b1)
    
    #coefficient operations
    #use the N variable again for gathering the number of observations as well as using numpy's sum functions to get the numerator and denominator
    coefNumerator = np.sum(N * (x * y)) - (np.sum(x) * np.sum(y))
    coefDenominator = np.sqrt((N * np.sum(x**2) - np.sum(x)**2) * (N * np.sum(y**2) - np.sum(y)**2))
    #divide the numerator and denominator to get the correlation coefficient
    r = coefNumerator / coefDenominator

    
    #r2: to get the coefficient of determinationm simply square the correlation of coefficient
    print("r2: ", r**2)

    #using numpy function for standard deviation
    print("Question 2")

    #standard deviation operations. initialize a second version of the b1 and b0 variables for use with the standard deviation operations
    b1v2 = r * (np.std(y) / np.std(x))

    b0v2 = yMean - (b1v2 * xMean)

    #print results for question 2
    print("b1: ", b1v2)

    print("b0: ", b0v2)

    print("r2: ", r**2)
    
    return (b0, b1)


linearRegression(x, y)
