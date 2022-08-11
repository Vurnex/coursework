'''
Lab Objective 

Number Analysis Program

Design a complete program that asks the user to enter a series of 20 numbers.  
The program should store the numbers in an array and then display each of the following data:

I.   The lowest number in the array
II.  The highest number in the array
III. The total of the numbers in the array
IV.  The average of the numbers in the array

'''

def main(): #calls modules and displays the number list

 NUMBER_OF_VALUES = 20
 
 numbersList = []
 
 numbersList = getValues(NUMBER_OF_VALUES)
 
 smallestValue = findsmallestValue(numbersList)
 
 biggestValue = findbiggestValue(numbersList)
 
 totalOfValues = calculatetotalOfValues(numbersList)
 
 averageOfValues = calculateaverageOfValues(numbersList, totalOfValues)
 
 printNumberAnalysis(numbersList, smallestValue, biggestValue, totalOfValues, averageOfValues)
 
def getValues(numberOfValues): #gets values inputted by user
 numbersList = []
 
 for currentValueIndex in range(numberOfValues):
   number = int(input("Please enter number " +\
     str((currentValueIndex + 1)) + ": "))
   numbersList.append(number)
 return numbersList
 
def findsmallestValue(numbersList): #finds the smallest value in the array
 smallestValue = min(numbersList)
 return smallestValue
 
def findbiggestValue(numbersList): #finds the largest value in the array
 biggestValue = max(numbersList)
 return biggestValue
 
def calculatetotalOfValues(numbersList): #calculates the sum of all submitted values
 totalOfValues = 0
 
 for currentValueIndex in range(len(numbersList)):
   totalOfValues = totalOfValues +\
     numbersList[currentValueIndex]
 return totalOfValues
 
def calculateaverageOfValues(numbersList, totalOfValues): #finds the average of the values
 numberOfValuesInList = len(numbersList)
 averageOfValues = totalOfValues / numberOfValuesInList
 return averageOfValues
 
def printNumberAnalysis(numbersList, smallestValue, biggestValue, totalOfValues, averageOfValues): #displays the final values in a horizontal list
 for currentValueIndex in range(len(numbersList)):
   if currentValueIndex == len(numbersList) -1:
     print(numbersList[currentValueIndex], end = ". ")
   else:
     print(numbersList[currentValueIndex], end = ", ")
 
 print("\nLowest Value: " + str(smallestValue), \
 "Highest Value: " + str(biggestValue), \
 "Total of Values: " + str(totalOfValues), \
 "Average of Values: " + format(averageOfValues, ".2f" ) , sep = "\n" )
 
main()