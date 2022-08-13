/* 
	
	Laquon Hamilton
	ITS-245
	9/12/20
	Lab 3
	Question 3

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_3
{
	class OddNums
	{
		
		static void Main(string[] args)
		{

			Console.WriteLine("\nProgram that displays all odd numbers between 1 and 99.\n");

			int i;

			for (i = 0; i < 100; i++)
			{
				if (i % 2 != 0)
				{
					Console.Write("{0}, ", i);
				}
			}

		}

	}
		
}
