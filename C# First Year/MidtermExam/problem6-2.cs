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
	
	class Patient 
	{ 
		private int patientID;
		private string lastName;
		private string firstName;
		private int age;
		private string eMail;

		public int PatientID { get => patientID; set => patientID = value; }
		public string LastName { get => lastName; set => lastName = value; }
		public string FirstName	{ get => firstName; set => firstName = value; }
		public int Age	{ get => age; set => age = value; }
		public string EMail	{ get => eMail; set => eMail = value; }

		public Patient(int patientID, string lastName, string firstName, int age, string eMail)
		{
			PatientID = patientID;
			LastName = lastName;
			FirstName = firstName;
			Age = age;
			EMail = eMail;
		}

		public void displayPatient()
		{
			Console.WriteLine("\nPatient ID: {0} \nLast Name: {1} \nFirst Name: {2} \nAge: {3} \nEmail: {4}", PatientID, LastName, FirstName, Age, EMail);
		}

	}
}

