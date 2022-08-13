/* 
	
	Laquon Hamilton
	ITS-245
	9/24/20
	Quiz 4

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Quiz_4
{
	class Cube : Square
	{
		private double length;

		public double Length { get => length; set => length = value; }

		public Cube()
		{ }

		public Cube(double width, double length, double height) : base(width, height)
		{
			this.length = length;
		}

		new public void display()
		{
			base.display();
			Console.WriteLine("Length: {0, 6:F2}", length);
		}

	}
}
