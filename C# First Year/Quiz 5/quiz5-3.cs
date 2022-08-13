/* 

	Laquon Hamilton
	ITS-245
	10/1/20
	Quiz 5


*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5
{
	class BloodData
	{
		private string bloodType;
		private string rhFactor;

		public string RhFactor { get => rhFactor; set => rhFactor = value; }
		public string BloodType { get => bloodType; set => bloodType = value; }

		public BloodData()
		{
			bloodType = "O";
			rhFactor = "+";
		}

		public BloodData(string bloddType, string rhFactor)
		{
			this.BloodType = bloddType;
			this.rhFactor = rhFactor;
		}

		public void display()
		{
			Console.WriteLine("Blood Type: {0}, RHFactor: {1}", bloodType, rhFactor);
		}
	}

}
