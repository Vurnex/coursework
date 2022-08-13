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
	//a restaurant in Manhattan
	
	class Restaurant 
	{ 
		private string name;
		private string kind;
		private string pricing;
		private Address address;

		public string Name { get => name; set => name = value; }
		public string Kind { get => kind; set => kind = value; }
		public string Pricing	{ get => pricing; set => pricing = value; }

		public Restaurant ()
		{

		}
		public Restaurant(string name, string kind, string pricing, Address address)
		{
			Name = name;
			Kind = kind;
			Pricing = pricing;
			this.address = address;
		}
		
		public Restaurant(string name, string kind, string pricing, string ave, int street)
		{
			Name = name;
			Kind = kind;
			Pricing = pricing;
			address = new Address(ave, street);
		}
		
		public void displayRestaurant()
		{
			Console.WriteLine("\nRestaurant Name: {0} \nType: {1} \nPrice: {2} \nAddress: 2101 {3} Ave \nStreet: {4}th St.", Name, Kind, Pricing, address.Ave, address.Street);
		}

	}

	//a intersection in Manhattan
	
	class Address
	{ 
		private string ave;
		private int street;

		public string Ave { get => ave; set => ave = value; }
		public int Street { get => street; set => street = value; }
		
		public Address (string ave, int street) 
		{
			this.ave = ave;
			this.street = street;
		}
	}
}
