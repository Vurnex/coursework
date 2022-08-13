/* 

	Laquon Hamilton
	ITS-245
	10/6/20
	Lab 6
	Problem 2

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class SchoolDemo
	{
		static void Main(string[] args)
		{
			
			School school = new School("New University", "2345 West St.", "Griffith", "IN", 46319);

			Student student = new Student("NewF", "StudentL", "3.0", "30 years", school);

			student.displayStudent();
    
		}
	}
	
}
