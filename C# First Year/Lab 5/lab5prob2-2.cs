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
	abstract class SalesPerson : ISellable
	{
		private string firstName;
		private string lastName;

		public string FirstName { get => firstName; set => firstName = value; }
		public string LastName { get => lastName; set => lastName = value; }

		public SalesPerson(string firstName, string lastName)
		{
			this.firstName = firstName;
			this.lastName = lastName;
		}

		public abstract string SalesSpeech();
		public abstract string MakeSale();

		public abstract string FullName();

	}
}
