/* 

	Laquon Hamilton
	ITS-245
	10/8/20
	Midterm Exam
	Problem 1

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermHL
{
	class NameDemo
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\nProgram where user enters names until they exit.");

			string newName;
			string validation = "Y";

			while (validation != "N")
			{
				Console.Write("\nWould you like to enter a new name? (Y/N): ");
				validation = Console.ReadLine();

				if (validation == "N")
				{
					Environment.Exit(0);
				}

				if (validation != "Y" && validation != "y")
				{
					Console.WriteLine("\nYou must enter Y or N.");
					Console.ReadKey();
				}

				Console.Write("\nPlease enter a first and last name: ");
				newName = Console.ReadLine();

				Console.WriteLine("\nThe name entered: {0}", newName);

				Console.ReadKey();

			}
    
		}
	}
	
}
