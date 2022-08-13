/* 
	
	Laquon Hamilton
	ITS-245
	9/12/20
	Lab 3
	Question 5

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_3
{
	class EnterValues
	{
		
		static void Main(string[] args)
		{
			Console.Clear();

			Console.WriteLine("\nProgram that asks user to enter a number between 1 and 10 and checks if the number is within a specific range.");

			int newNumber = 0;
			int i = 0; 
			string enterMore = "";
			int[] numberArray = new int[1];

			Console.Write("\nPlease enter a number between 1 and 10: ");
			string line = Console.ReadLine();

			if (int.TryParse(line, out newNumber))
			{
			
				if (newNumber < 1 || newNumber > 10)
				{
					Console.Write("\nYou entered a number outside the range of 1 - 10. Do you want to enter another number or quit? (yes/quit): ");
					enterMore = Console.ReadLine();
				
					while (enterMore != "yes" && enterMore != "quit")
					{
						Console.WriteLine("\nYou must enter 'yes' or 'quit' .");
						Console.Write("\nDo you want to enter another number or quit?(yes/quit): ");
						enterMore = Console.ReadLine();
					}

					if (enterMore == "yes")
					{
						EnterValues.Main(args);
					}
					if (enterMore == "quit")
					{
						Environment.Exit(0);
					}
				}
				
				else
				{
					numberArray[i] = newNumber;
					EnterValues.displayByVal(numberArray, i);
					EnterValues.displayByRef(ref numberArray, ref i);
				}

			}
			else
			{
				Console.WriteLine("\nYou must enter an integer. Press enter to continue.");
				Console.ReadLine();
				EnterValues.Main(args);
			}

		}

		static void displayByVal(int[] numberArray, int i)
		{

			Console.WriteLine("\nShowing number in array by value: {0}", numberArray[i]);

		}

		static void displayByRef(ref int[] numberArray, ref int i)
		{
			
			Console.WriteLine("\nShowing number in array by reference: {0}", numberArray[i]);
	
		}

	}
		
}
