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

	class FramedPhoto : Photo
	{
		private string material;
		private string style;

		public string Material { get => material; set => material = value; }
		public string Style { get => style; set => style = value; }

		public FramedPhoto() { }

		public FramedPhoto(double width, double height, string material, string style) : base(width, height)
		{
			this.material = material;
			this.style = style;

			price += 25; 
		}

		public void setFramedPhotoDimension(double width, double height)
		{
			base.Width = width;
			base.Height = height;

			price += 25;
		}

		public override string ToString()
		{
			return GetType() + " - Material: " + material + " Style: " + style + base.Width + " inch by " + base.Height + " inch, Price: " + price.ToString("C");
		}		
	}

}