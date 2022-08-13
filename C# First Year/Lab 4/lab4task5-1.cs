/* 
	
	Laquon Hamilton
	ITS-245
	9/21/20
	Lab 4
	Task 5

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_4
{
	class DemoJobs
	{
		static void Main(string[] args)
		{
			Job jobProject1 = new Job("Construction Project Manager", 16, 42.02);
			Job jobProject2 = new Job("Construction Surveyor", 12, 34.06);

			Job jobProject3 = jobProject1 + jobProject2;

			Console.WriteLine("\nThe job Project 1 is {0}, requires {1} hours with a rate of ${2, 6:F2} per hour.", jobProject1.jobDescription, jobProject1.NumberOfHours, jobProject1.HourlyRate);
			Console.WriteLine("\nThe job Project 1 total cost is ${0}.", jobProject1.TotalFee);
			Console.WriteLine("\nThe job Project 2 is {0}, requires {1} hours with rate of ${2, 6:F2} per hour.", jobProject2.jobDescription, jobProject2.NumberOfHours, jobProject2.HourlyRate);
			Console.WriteLine("\nThe job Project 2 total cost is ${0}.", jobProject2.TotalFee);

			Console.WriteLine("\nThe job Project 3 is {0}, requires {1} hours with rate of ${2, 6:F2} per hour.", jobProject3.jobDescription, jobProject3.NumberOfHours, jobProject3.HourlyRate);
			Console.WriteLine("\nThe job Project 3 total cost is ${0}.", jobProject3.TotalFee);

			Console.ReadKey();

		}
	
	}
}
