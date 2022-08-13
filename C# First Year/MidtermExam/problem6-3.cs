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
	class OutPatient : Patient
	{
		private int doctorOfficeID;

		public int DoctorOfficeID { get => doctorOfficeID; set => doctorOfficeID = value; }

		public OutPatient(int patientID, string lastName, string firstName, int age, string eMail, int doctorOfficeID) : base(patientID, lastName, firstName, age, eMail)
		{
			DoctorOfficeID = doctorOfficeID;
		}

/*
		public void displayOutPatient()
		{
			Console.WriteLine("\nFirst Name: {0} \nLast Name: {1} \nSchool Age: {2} \ndoctorOfficeID: {3} \nSchool Object Ref: {4}", FirstName, LastName, Age, doctorOfficeID, );

		}
		*/
		
	}

}
