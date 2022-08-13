/* 

	Laquon Hamilton
	ITS-245
	10/8/20
	Midterm Exam
	Problem 7

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

		public override void displayPatient()
		{
			Console.WriteLine("\nPatient ID: {0} \nLast Name: {1} \nFirst Name: {2} \nAge: {3} \nEmail: {4} \nDoctor's Office ID: {5}", PatientID, LastName, FirstName, Age, EMail, DoctorOfficeID);
		}
		
	}

}
