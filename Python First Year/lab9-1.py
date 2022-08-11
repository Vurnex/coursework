'''

Lab 9 Question 1

Design a complete program that opens an output file with the external name my_name.dat, 
writes your name to the file, and then closes the file.

'''

def main(): #create an array size 1 and a counter starting at 0
 arrSize = 1
 counter = 0
 userName = [0] * arrSize
 #enters the username
 for counter in range(arrSize):
   userName[counter] = input("Please enter your name: ")
 
 writeToFile(arrSize, userName) #write the data to a file
 
def writeToFile(arraySize, name):
 #open the file for writing
 myFile = open("my_name.dat","w")
 count = 0
 #loop through the array
 for count in range(arraySize):
   #write each element of the array to a file
   myFile.write(name[count] +"\n")
 myFile.close() #close the file
 
main()