/* 

	Laquon Hamilton
	ITS-245
	10/8/20
	Midterm Exam
	Problem 4

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
			//Patient patient1 = new Patient("\nTesting Main...");

			Patient patient2 = new Patient(2568, "CRAWFORD", "Mike", 35, "mike.crawford@hotmail.com");

			patient2.displayPatient();
    
		}
	}
	
}
