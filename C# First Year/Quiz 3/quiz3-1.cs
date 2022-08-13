/* 
	
	Laquon Hamilton
	ITS-245
	9/17/20
	Quiz 3

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Quiz_3
{
	class Car
	{
		private string model;
		private int year;
		private int mpg;

		public string Model { get => model; set => model = value; }
    public int Year { get => year; set => year = value; }
    public int Mpg { get; set; }
		
		public Car() { }

		public Car(string model)
		{
				this.model = model;
		}

		public Car(string model, int year)
		{
			this.model = model;
			this.year = year;
		}
		
		
	}
}
