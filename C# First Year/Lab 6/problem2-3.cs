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
	class Student : Person
	{
		private string gpa;
		private string age;

		public string Gpa { get => gpa; set => gpa = value; }
		public string Age { get => age; set => age = value; }

		public School schoolType = new School();
		
		public Student()
		{

		}

		public Student(string gpa, string age, School schoolType)
		{
			Gpa = gpa;
			Age = age;
			this.schoolType = schoolType;
		}

		public Student(string Name, string Address, string City, string State, int ZipCode)
		{
			schoolType = new School(Name, Address, City, State, ZipCode);
		}

		public Student(string FirstName, string LastName, string gpa, string age, School schoolType) : base(FirstName, LastName)
		{
			Gpa = gpa;
			Age = age;
		}

		public void displayStudent()
		{
			Console.WriteLine("\nFirst Name: {0} \nLast Name: {1} \nSchool Age: {2} \nGPA: {3} \nSchool Object Ref: {4}", FirstName, LastName, Age, Gpa, schoolType);

		}
		
	}

}