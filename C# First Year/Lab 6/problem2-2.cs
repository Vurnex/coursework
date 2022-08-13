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
	
	class Person 
	{ 
		private string firstName;
		private string lastName;

		public string FirstName { get => firstName; set => firstName = value; }
		public string LastName { get => lastName; set => lastName = value; }

		public Person()
		{

		}
		public Person(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

	}

}
