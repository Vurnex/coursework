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

	class School
	{
		private string name;
		private string address;
		private string city;
		private string state;
		private int zipCode;

		public string Name { get => name; set => name = value; }
		public string Address { get => address; set => address = value; }
		public string City { get => city; set => city = value; }
		public string State { get => state; set => state = value; }
		public int ZipCode { get => zipCode; set => zipCode = value; }

		public School()
		{

		}
		public School(string name, string address, string city, string state, int zipCode)
		{
			this.name = name;
			this.address = address;
			this.city = city;
			this.state = state;
			this.zipCode = zipCode;
		}
	}

}