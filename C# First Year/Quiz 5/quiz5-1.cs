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
	class PatientDemo
	{
		static void Main(string[] args)
		{
			BloodData bloodType = new BloodData("B", "+");
			Patient patient1 = new Patient("1101", 35, bloodType, "312-596-2329", "joe.patient@gmail.com", "Joe Benard");

			patient1.display();
			Console.ReadKey();
		}
	}
	
}
