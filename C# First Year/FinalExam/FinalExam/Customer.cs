/* 

	Laquon Hamilton
	ITS-245
	12/16/20
	Final Exam
	Question 1, 2, 3, 4, 5

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamLH
{

	class Customer
	{
		private string customerID;
		private string customerName;
		private CustomerAddress address;

		public string CustomerID { get => customerID; set => customerID = value; }
		public string CustomerName { get => customerName; set => customerName = value; }
		internal CustomerAddress Address { get => address; set => address = value; }

		public Customer()
		{

		}

		public Customer(string customerID, string customerName, CustomerAddress address)
		{
			CustomerID = customerID;
			CustomerName = customerName;
			Address = address;
		}

		public void DisplayCustomerInfo()
		{
			Console.WriteLine("\n-----Displayed from Customer class-----\n");
			Console.WriteLine("Customer #" + CustomerID + " is named " + CustomerName + ".\n");
			Console.WriteLine("The customer lives in " + Address.City + ", " + Address.State + "," + Address.ZipCode + ".\n");
			Console.WriteLine("-----------------------------------------\n");
		}

	}

}
