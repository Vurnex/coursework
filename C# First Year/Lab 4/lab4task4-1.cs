/* 
	
	Laquon Hamilton
	ITS-245
	9/21/20
	Lab 4
	Task 4

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_4
{
	class SchoolsDemo
	{
		static void Main(string[] args)
		{
			int i = 0;
			int currentNum = 1;

			Schools [] myschoolArray = new Schools[3];

			for (i = 0; i < myschoolArray.Length; ++i)
			{
				myschoolArray[i] = new Schools();
			}

			for (i = 0; i < myschoolArray.Length; i++)
			{
				Console.Clear();
				Console.WriteLine("\n    ========== {0} ==========", currentNum);
				Console.Write("\nPlease enter the school's name: ");
				myschoolArray[i].SchoolName = Console.ReadLine();

				Console.Write("\nPlease enter the school's enrollment size: ");
				myschoolArray[i].EnrollSize = Convert.ToInt32(Console.ReadLine());

				
				currentNum++;
				
			}

      Array.Sort(myschoolArray);

			int minEnrollment;

			Console.Clear();

			Console.Write("\nPlease enter a minimum enrollment number: ");
			Int32.TryParse(Console.ReadLine(), out minEnrollment);

			Console.WriteLine("\n=======================");

			Console.WriteLine("\nThe schools with a minimum of {0} enrollments: ", minEnrollment);

			for (i = 0; i < myschoolArray.Length; i++)
			{
				if(myschoolArray[i].EnrollSize >= minEnrollment)
				{
					Console.WriteLine("\nThe {0} school has {1} enrollments.", myschoolArray[i].SchoolName, myschoolArray[i].EnrollSize);

				
				}
			}
			
		}
	}
}
