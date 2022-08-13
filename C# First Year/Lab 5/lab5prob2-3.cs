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
	class RealEstateSalesPerson : SalesPerson
	{
		private int totalValueSold;
		private double totalCommisionEarned;
		private double commisionRate;

		public int TotalValueSold { get => totalValueSold; set => totalValueSold = value; }
		public double TotalCommisionEarned { get => totalCommisionEarned; set => totalCommisionEarned = value; }
		public double CommisionRate { get => commisionRate; set => commisionRate = value; }

		public RealEstateSalesPerson(string firstName, string lastName, double commisionRate) : base(firstName, lastName)
		{
			totalValueSold = 0;
			totalCommisionEarned = 0;

			this.commisionRate = commisionRate;
		}

		public override string SalesSpeech()
		{
			return "\nHi, I am " + FullName() + ". Would you like to see a new house today?";
		}

		public override string MakeSale()
		{
			Console.Write("\nEnter the sales price of the new house: ");
			string inputStr = Console.ReadLine();
			int salesValue;
			Int32.TryParse(inputStr, out salesValue);

			totalValueSold += salesValue;
			totalCommisionEarned += salesValue * commisionRate;

			return "\nThe total value sold is " + totalValueSold.ToString("C") + " with a commission of " + totalCommisionEarned.ToString("C")+"\n";
		}

		public override string FullName()
		{
			return base.FirstName + " " + base.LastName;
		}
    
	}

}
