/* 

	Laquon Hamilton
	ITS-245
	10/8/20
	Midterm Exam
	Problem 5

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermHL
{
	
	class Patient 
	{
		private int age;
		private double visitRate;
		private double discountRate;

		public int Age	{ get => age; set => age = value; }
		public double VisitRate	{ get => visitRate; set => visitRate = value; }
		public double DiscountRate	{ get => discountRate; set => discountRate = value; }

		public Patient()
		{

		}

		public Patient(int age)
		{
			Age = age;			
			
			if (Age > 65)
			{
				visitRate = 75;
			}			
			else if (Age < 65)
			{
				visitRate = 125;
			}
		}

		public Patient(double discountRate)
		{
			this.discountRate = discountRate;

			if (Age > 65)
			{
				visitRate = 75;			
				visitRate = visitRate * discountRate;
			}

		}

		public void displayPatient()
		{
			if (Age < 65)
			{
				Console.WriteLine("\nThe rate for a doctor visit for patients under 65 is {0}.", VisitRate);
			}
			else if (Age > 65)
			{
				Console.WriteLine("\nThe rate for a doctor visit for patients over 65 is {0}.", VisitRate);
			}
		}

	}
}

