def main():
    #initialize values to be inputted by user
    value1 = input("\nEnter the first value: ")
    value2 = input("\nEnter the second value: ")

    #initialize the operation string to be inputted by user
    operation = input("\nEnter the operation to be used: ")

    #determine which function to call based on the desired operation
    if operation == str("addition"):
        addValues(value1, value2)
    elif operation == str("subtraction"):
        subValues(value1, value2)
    elif operation == str("multiplication"):
        multValues(value1, value2)
    elif operation == str("division"):
        divValues(value1, value2)

def addValues(value1, value2):
    sum = 0 #initialize sum value

    #verify which function is being called and the values sent to it
    print("\nIn Addition Function. Values retrieved: ", value1 + " & " + value2)

    #add the values
    sum = int(value1) + int(value2)

    #print the sum
    print("\nThe sum is: ", sum)
        

def subValues(value1, value2):
    sum = 0

    print("\nIn Subtraction Function. Values retrieved: ", value1 + " & " + value2)

    #subtract the values
    sum = int(value1) - int(value2)

    print("\nThe difference is: ", sum)

def multValues(value1, value2):
    sum = 0

    print("\nIn Multiplication Function. Values retrieved: ", value1 + " & " + value2)

    #multiply the values
    sum = int(value1) * int(value2)

    print("\nThe product is: ", sum)
    
def divValues(value1, value2):
    sum = 0

    print("\nIn Division Function. Values retrieved: ", value1 + " & " + value2)

    #divide the values
    sum = int(value1) / int(value2)

    print("\nThe quotient is: ", sum)


main()
        
