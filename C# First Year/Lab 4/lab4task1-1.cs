/* 
	
	Laquon Hamilton
	ITS-245
	9/20/20
	Lab 4
	Task 1

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_4
{
	class TestClassifiedAd
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\nProgram that instantiates and displays an object from another program.");

			ClassifiedAd myClassifiedAd = new ClassifiedAd();

			myClassifiedAd.UsedBooks = "Beginning: Programming in C#";
			myClassifiedAd.NumWords = 9205;

			myClassifiedAd.displayBookInfo();

			Console.ReadKey();

		}		
	}
}
