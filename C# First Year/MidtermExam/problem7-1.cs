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
	class PatientDemo
	{
		static void Main(string[] args)
		{
			OutPatient patient1 = new OutPatient(2568, "CRAWFORD", "Mike", 35, "mike.crawford@hotmail.com", 089);
			
			InPatient patient2 = new InPatient(2568, "CRAWFORD", "Mike", 35, "mike.crawford@hotmail.com", 0986);

			patient1.displayPatient();
			patient2.displayPatient();

			//Console.WriteLine("\nPatient ID: {0} \nLast Name: {1} \nFirst Name: {2} \nAge: {3} \nEmail: {4} \nDoctor's Office ID: {5} \nHospital ID: {6}", patient1.PatientID, patient1.LastName, patient1.FirstName, patient1.Age, patient1.EMail, patient1.DoctorOfficeID, patient2.HospitalID);
    
		}
	}
	
}
