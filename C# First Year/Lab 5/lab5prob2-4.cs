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

	class GirlScout : SalesPerson
	{
		private int totalBoxes;

		public int TotalBoxes { get => totalBoxes; set => totalBoxes = value; }

		public GirlScout(string firstName, string lastName) : base(firstName, lastName)
		{
			totalBoxes = 0;
		}

		public override string FullName()
		{
			return base.FirstName + " " + base.LastName;
		}

		public override string SalesSpeech()
		{
			return "\nHi, I am " + FullName() + ". Would you like to buy some cookies?";
		}

		public override string MakeSale()
		{
			Console.Write("\nEnter the number of cookie boxes sold: ");
			string inputStr = Console.ReadLine();
			int numBoxes;
			Int32.TryParse(inputStr, out numBoxes);

			totalBoxes += numBoxes;

			return "\nA total of " + totalBoxes + " boxes of cookies were sold.\n";
		}
	}

}