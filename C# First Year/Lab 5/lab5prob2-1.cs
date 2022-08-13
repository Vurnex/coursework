/* 

	Laquon Hamilton
	ITS-245
	9/26/20
	Lab 5
	Problem 2

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	class SalesPersonDemo
	{
		static void Main(string[] args)
		{
			RealEstateSalesPerson realEstateSalesPerson = new RealEstateSalesPerson("Jane", "Doe", 0.05);

			GirlScout girlScout = new GirlScout("Hermione", "Granger");

			Console.WriteLine(realEstateSalesPerson.SalesSpeech());

			Console.ReadLine();

			Console.WriteLine(realEstateSalesPerson.MakeSale());

			Console.WriteLine(girlScout.SalesSpeech());

			Console.ReadLine();

			Console.WriteLine(girlScout.MakeSale());

			Console.ReadKey();
			
		}
	}
	
}
