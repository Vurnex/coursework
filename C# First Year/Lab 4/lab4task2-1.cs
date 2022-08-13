/* 
	
	Laquon Hamilton
	ITS-245
	9/20/20
	Lab 4
	Task 2

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_4
{
	class SalesTransactionDemo
	{
		static void Main(string[] args)
		{
			SalesTransaction transaction1 = new SalesTransaction("Rayyan Mccaffrey", 1500.00, 0.07);
			SalesTransaction transaction2 = new SalesTransaction("Juan Kavanagh", 650.00);
			SalesTransaction transaction3 = new SalesTransaction("Jenna Morris");

			double totalTransactionAmount = transaction1.getTotalPrice() + transaction2.getTotalPrice() + transaction3.getTotalPrice();

			Console.WriteLine("The total amount of sales transactions is ${0, 7:F2}", totalTransactionAmount);
			
			Console.ReadKey();
		}
	}
}
