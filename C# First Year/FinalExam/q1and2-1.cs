/* 

	Laquon Hamilton
	ITS-245
	12/15/20
	Final Exam
	Question 1, 2

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamLH
{
	class CustomerDemo
	{
		static void Main(string[] args)
		{

			Console.Clear();

			//Question 1
			CustomerAddress address1 = new CustomerAddress("Napoleonland", "MN", " 69045");

			Customer c1 = new Customer();

			c1.CustomerID = "14509";
			c1.CustomerName = "Garry Gibson";
			c1.Address = address1;

			Customer c2 = new Customer("21973", "Ida McDermott", address1);

			//Question 2

			DisplayCustomer(c1);
			c2.DisplayCustomerInfo();

			Console.ReadKey();
		}

		public static void DisplayCustomer(Customer c)
		{
			Console.WriteLine("Customer #" + c.CustomerID + " is named " + c.CustomerName + ".\n");
			Console.WriteLine("The customer lives in " + c.Address.City + ", " + c.Address.State + "," + c.Address.ZipCode + ".\n");
		}
	}
	
}
