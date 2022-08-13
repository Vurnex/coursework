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
	class Square
	{
		private double width;
		private double height;

		public double Width { get => width; set => width = value; }
		public double Height { get => height; set => height = value; }

		public Square() { }

		public Square(double width, double height)
		{
			this.width = width;
			this.height = height;
		}	

		public void display()
		{

			Console.WriteLine("\nWidth: {0, 6:F2}", width);
			Console.WriteLine("Height: {0, 6:F2}", height);

		}
	}

}
