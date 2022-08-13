/* 
	
	Laquon Hamilton
	ITS-245
	9/12/20
	Lab 3
	Question 1

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_3
{
	class Admission
	{
		
		static void Main(string[] args)
		{
			Console.Clear();

			Console.WriteLine("\nProgram that determines if a student meets the requirements for college admissions.");

			double gradeptAverage;
			int testScore;

			Console.Write("\nPlease enter the student's GPA: ");
			gradeptAverage = Convert.ToDouble(Console.ReadLine());

			Console.Write("\nPlease enter the student's test score: ");
			testScore = Convert.ToInt32(Console.ReadLine());

			if (gradeptAverage >= 3.0 && testScore >= 60 || gradeptAverage < 3.0 && testScore >= 80 )
			{
				Console.WriteLine("\nAccepted");
			}
			else
			{
				Console.WriteLine("\nRejected");
			}
			
			Console.WriteLine("\nGPA: {0}, Test Score: {1}", gradeptAverage, testScore);

			Console.ReadLine();

		}

	}
		
}

