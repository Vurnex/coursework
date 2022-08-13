import numpy as np

#load text data from each file into each variable. only columns specified will be used, the first row will be skipped, and the delimiter is the spaces in the file
hwData = np.loadtxt('lab2-hw.txt', usecols = (1,2,3,4,5), skiprows = 1, delimiter = "	")

projectData = np.loadtxt('lab2-project.txt', usecols = 1, skiprows = 1, delimiter = "	")

quizData = np.loadtxt('lab2-quiz.txt', usecols = (1,2,3,4,5), skiprows = 1, delimiter = "	")

testData = np.loadtxt('lab2-test.txt', usecols = (1,2), skiprows = 1, delimiter = "	")

#initialize new variables to store each student's data arrays
homeworkArray = np.array([hwData[0], hwData[1], hwData[2], hwData[3], hwData[4], hwData[5]])

projectArray = np.array([projectData[0], projectData[1], projectData[2], projectData[3], projectData[4], projectData[5]])

quizArray = np.array([quizData[0], quizData[1], quizData[2], quizData[3], quizData[4], quizData[5]])

testArray = np.array([testData[0], testData[1], testData[2], testData[3], testData[4], testData[5]])

#arrays used to store the weighted grade for each student in each category
homeworkArrayGrade = []

projectArrayGrade = []

quizArrayGrade = []

testArrayGrade = []

#use for loops to iterate through each students individual data. add the grades then set the weighted grade to the quotient of the total and multiply by 100 to get the weighted grade
for x in homeworkArray:
    weightedGrade = 0
    for y in x:
        weightedGrade += y
    weightedGrade = (weightedGrade / 250) * 100
    homeworkArrayGrade.append(weightedGrade)

#since there is only one project grade, it only needs to be added / appended to the project grades array
for x in projectArray:
    projectArrayGrade.append(x)
    
for x in quizArray:
    weightedGrade = 0
    for y in x:
        weightedGrade += y
    weightedGrade = (weightedGrade / 50) * 100
    quizArrayGrade.append(weightedGrade)
    
for x in testArray:
    weightedGrade = 0
    for y in x:
        weightedGrade += y
    weightedGrade = (weightedGrade / 200) * 100
    testArrayGrade.append(weightedGrade)
    
#take each grade array and stack them as columns to make a single 2-D array. 
totalGradeArray = np.column_stack((homeworkArrayGrade, quizArrayGrade, testArrayGrade, projectArrayGrade))

#array which stores each category's weight
weightArray = np.array([.30, .10, .40, .20])

#use matrix multiplication on the total grades and the weights to achieve the final grades
finalGradesArray = np.matmul(totalGradeArray, weightArray)

#set the array to act as a list so commas are displayed between values
finalGradesListed = finalGradesArray.tolist()

print(finalGradesArray)

#for testing purposes. there are two values which contain zeroes at the end so I decided to leave it commented out as I'm not sure if it would be correct.
#print(finalGradesListed)






