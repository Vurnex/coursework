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
	class Job
	{
		public string jobDescription { get; set; }
		private double numberOfHours;
		private double hourlyRate;

		readonly double totalFee;

		public double NumberOfHours { get => numberOfHours; set => numberOfHours = value; }
		public double HourlyRate { get => hourlyRate; set => hourlyRate = value; }

		public double TotalFee => totalFee;

		public Job()
		{
			jobDescription = "";
			numberOfHours = 0;
			hourlyRate = 0;
			totalFee = 0;
		}

		public Job(string description, double numberOfHours, double hourlyRate)
		{
				jobDescription = description;
				this.numberOfHours = numberOfHours;
				this.hourlyRate = hourlyRate;
				totalFee = numberOfHours* hourlyRate;
		}

		public static Job operator +(Job cp1, Job cp2)
		{
			string description = cp1.jobDescription + " and " + cp2.jobDescription;
			double newHours = cp1.NumberOfHours + cp2.NumberOfHours;
			double addPrice = cp1.totalFee + cp2.totalFee;
			double newHourlyRate = addPrice / newHours;

			Job result = new Job(description, newHours, newHourlyRate);
			return result;
		}

  }
}
