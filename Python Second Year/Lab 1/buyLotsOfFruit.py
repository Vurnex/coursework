# buyLotsOfFruit.py
# -----------------
# Licensing Information:  You are free to use or extend these projects for
# educational purposes provided that (1) you do not distribute or publish
# solutions, (2) you retain this notice, and (3) you provide clear
# attribution to UC Berkeley, including a link to http://ai.berkeley.edu.


from __future__ import print_function

fruitPrices = {'apples': 2.00, 'oranges': 1.50, 'pears': 1.75,
               'limes': 0.75, 'strawberries': 1.00}


def buyLotsOfFruit(orderList):
    """
        orderList: List of (fruit, numPounds) tuples

    Returns cost of order
    """
    totalCost = 0.0
    "*** YOUR CODE HERE ***"

    for fruit, numPounds in orderList: #loop over the fruit and prices in the fruitPrices dictionary
        if fruit not in fruitPrices: #for a fruit that is found in the iteration but not in the list
            print("The fruit %s is not in the list", fruit) #prints an error to the terminal with the fruit that wasn't found
            return None #ends both the loop and the function and returns None to main

        cost = fruitPrices[fruit] #set cost to the price listed with the fruit which will be used to calculate the total cost

        totalCost = totalCost + numPounds * cost #multiplies the pounds and the price to get the cost of the individual
                                                #fruit, then adds each price of those fruits to get the total cost
        print(totalCost) #for verifying the total cost through each iteration
        
    return totalCost #return the total cost to the main function and ends the function


# Main Method
if __name__ == '__main__':
    "This code runs when you invoke the script from the command line"
    
    orderList = [('apples', 2.0), ('pears', 3.0), ('limes', 4.0)] #each fruit along with its number of pounds
    
    print('Cost of', orderList, 'is', buyLotsOfFruit(orderList))  #calls the function to iterate each fruit with
                                                                  #its number of pounds to gather the total cost
