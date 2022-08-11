'''

Lab 9 Question 4

Design a complete program that opens the number_list.dat file that was created by the program in #3 above, 
reads all of the numbers from the file and displays them, and then closes the file.

'''

def main():#open the file for writing
    
    myFile = open("number_list.dat","w")

    for i in range(1,101): #counts from 1 to 100
        myFile.write(str(i) +"\n") #writes to the file
    
    myFile.close() #closes the file
    
    inFile = open("number_list.dat", "r") #opens and reads the file
    line = inFile.readline() #reads the lines in the file
    
    while line != "": #loops through each line until it reaches an empty string
        print(line)
        line = inFile.readline()
    
    inFile.close()

main()