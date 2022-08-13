/* 
	
	Laquon Hamilton
	ITS-245
	9/22/20
	Lab 4
	Task 3

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

				Console.Write("\nPlease enter the school's district: ");
				myschoolArray[i].SchoolDistrict = Console.ReadLine();

				Console.Write("\nPlease enter the school's enrollment size: ");
				myschoolArray[i].EnrollSize = Convert.ToInt32(Console.ReadLine());

				Console.Write("\nPlease enter the school's age: ");
				myschoolArray[i].SchoolAge = Convert.ToInt32(Console.ReadLine());

				Console.Write("\nPlease enter the school's ID number: ");
				myschoolArray[i].SchoolID = Convert.ToInt32(Console.ReadLine());

				currentNum++;
				
			}

			currentNum = 1;

			Console.Clear();

			Array.Sort(myschoolArray, delegate(Schools x, Schools y) { return x.EnrollSize.CompareTo(y.EnrollSize); });			

			for (i = 0; i < myschoolArray.Length; i++)
			{
				Console.WriteLine("\n    ========== {0} ==========", currentNum);
				Console.WriteLine("\nSchool Name: {0} \nSchool District: {1} \nEnrollment Size: {2} \nSchool Age: {3} \nSchool ID #: {4}", myschoolArray[i].SchoolName, myschoolArray[i].SchoolDistrict, myschoolArray[i].EnrollSize, myschoolArray[i].SchoolAge, myschoolArray[i].SchoolID);

				currentNum++;
			}
			
		}
	}
}
