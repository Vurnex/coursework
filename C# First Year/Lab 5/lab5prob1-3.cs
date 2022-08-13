/* 

	Laquon Hamilton
	ITS-245
	9/26/20
	Lab 5
	Problem 1

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	class MattedPhoto : Photo
	{
		private string color;

		public string Color { get => color; set => color = value; }

		public MattedPhoto() { }

		public MattedPhoto(double width, double height, string color) : base(width, height)
		{
			this.color = color;

			price += 10;
		}

		public void setMattedPhotoDimension(double width, double height)
		{
			base.Width = width;
			base.Height = height;

			price += 10;
		}

		public override string ToString()
		{
			return GetType() + " - Color: " + color + base.Width + " inch by " + base.Height + " inch, Price: " + price.ToString("C");
		}
    
	}

}
