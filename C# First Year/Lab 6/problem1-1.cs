/* 

	Laquon Hamilton
	ITS-245
	10/6/20
	Lab 6
	Problem 1

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class RestaurantDemo
	{
		static void Main(string[] args)
		{
			Restaurant restaurant = new Restaurant("McDonalds", "Fast Food", "Burger: $3.99", "Wentworth", 10);
			restaurant.displayRestaurant();
    
		}
	}
	
}
