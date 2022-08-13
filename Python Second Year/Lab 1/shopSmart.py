# shopSmart.py
# ------------
# Licensing Information:  You are free to use or extend these projects for
# educational purposes provided that (1) you do not distribute or publish
# solutions, (2) you retain this notice, and (3) you provide clear
# attribution to UC Berkeley, including a link to http://ai.berkeley.edu.


from __future__ import print_function

import shop

def shopSmart(orderList, fruitShops):
    """
        orderList: List of (fruit, numPound) tuples
        fruitShops: List of FruitShops
    """
    "*** YOUR CODE HERE ***"
    
    theBestShop = fruitShops[0] #initialize both the best shop and fruitshops and set the best shop to equal the first index in fruitShops

    theLowestCost = theBestShop.getPriceOfOrder(orderList) #sets the first lowest cost to that of the first order's price

    for shop in fruitShops[1:]: #iterate through fruitShops starting from the 2nd element to the end of the array
        cost = shop.getPriceOfOrder(orderList) #set cost to that of the current index (order's) price
        if cost < theLowestCost: #if the current price is less than the previously established lowest cost, then
            theBestShop = shop #set the best shop to the shop in the current iteration / index
            theLowestCost = cost #set the lowest cost to the price in the current iteration / index
    
    return theBestShop #return the best shop to the main function and end the shopSmart function


if __name__ == '__main__':
    "This code runs when you invoke the script from the command line"
    orders = [('apples', 1.0), ('oranges', 3.0)]
    dir1 = {'apples': 2.0, 'oranges': 1.0}
    shop1 = shop.FruitShop('shop1', dir1)
    dir2 = {'apples': 1.0, 'oranges': 5.0}
    shop2 = shop.FruitShop('shop2', dir2)
    shops = [shop1, shop2]
    print("For orders ", orders, ", the best shop is", shopSmart(orders, shops).getName())
    orders = [('apples', 3.0)]
    print("For orders: ", orders, ", the best shop is", shopSmart(orders, shops).getName())
