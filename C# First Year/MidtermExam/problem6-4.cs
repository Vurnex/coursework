/* 

	Laquon Hamilton
	ITS-245
	10/8/20
	Midterm Exam
	Problem 6

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermHL
{

	class InPatient : Patient
	{
		private int hospitalID;

		public int HospitalID { get => hospitalID; set => hospitalID = value; }

		public InPatient(int patientID, string lastName, string firstName, int age, string eMail, int hospitalID) : base(patientID, lastName, firstName, age, eMail)
		{
			this.hospitalID = hospitalID;
		}
	}

}