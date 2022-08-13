/* 

	Laquon Hamilton
	ITS-245
	10/8/20
	Midterm Exam
	Problem 2

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
			
			Patient patient1 = new Patient(2568, "CRAWFORD", "Mike", 35, "mike.crawford@hotmail.com");

			Console.WriteLine("\nPatient ID: {0} \nLast Name: {1} \nFirst Name: {2} \nAge: {3} \nEmail: {4}", patient1.PatientID, patient1.LastName, patient1.FirstName, patient1.Age, patient1.EMail);
    
		}
	}
	
}
