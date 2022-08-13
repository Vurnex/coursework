/* 
	
	Laquon Hamilton
	ITS-245
	9/10/20
	Quiz 2

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Quiz_2
{
	class Program
	{
		
		static void Main(string[] args)
		{
			Console.Clear();
			Console.WriteLine("Program that displays information about a computer stored in a separate file.");
			Computer myComputer = new Computer();
			myComputer.Manufacturer = "Asus";
			myComputer.ModelNumber = "F510UA";
			myComputer.Price = 500;

			myComputer.displayComputer();

			Console.ReadLine();

		}

	}
		
}

