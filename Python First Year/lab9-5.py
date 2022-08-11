'''

Lab 9 Question 5

Modify the program created in #4 above so that it reads in all of the numbers from the file, 
add them together, and then displays the total.

'''

def main():

    myFile = open("number_list.dat","w")
    
    for i in range(1,101): #counts from 1 to 100
        myFile.write(str(i) +"\n") #writes to the file
    
    myFile.close() #closes the file
    
    readFile = open("number_list.dat",'r')
    lines = readFile.readlines() #reads each line
    counter = 0
    
    for line in lines: #loops through each line
        total = int(line)
        counter = counter + total
    print("The total is:", counter)
    
    readFile.close()

main()