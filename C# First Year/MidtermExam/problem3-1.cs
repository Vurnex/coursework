/* 

	Laquon Hamilton
	ITS-245
	10/8/20
	Midterm Exam
	Problem 3

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermHL
{
	class TestMain
	{
		static void Main(string[] args)
		{
			Patient patient1 = new Patient("\nTesting Main...");

			Patient patient2 = new Patient(2568, "CRAWFORD", "Mike", 35, "mike.crawford@hotmail.com");

			Console.WriteLine("{0}", patient1.TestMain);

			Console.WriteLine("\nPatient ID: {0} \nLast Name: {1} \nFirst Name: {2} \nAge: {3} \nEmail: {4}", patient2.PatientID, patient2.LastName, patient2.FirstName, patient2.Age, patient2.EMail);
    
		}
	}
	
}
