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
	class Photo
	{
		private double width;
		private double height;

		protected double price;

		public double Width
		{
			get
			{
				return width;
			}
			set
			{
				width = value;
				setPrice();
			}

		}
		public double Height
		{
			get
			{
				return height;
			}

			set
			{
				height = value;
				setPrice();
			}
		}

		protected double Price { get => price; }

		public Photo() { }

		private void setPrice()
		{
			if (width == 8.0 && height == 10.0)
			{
				price = 3.99;
			}
			else if (width == 10.0 && height == 12.0)
			{
				price = 5.99;
			}
			else
			{
				price = 9.99;
			}
		}

		public Photo(double width, double height)
		{
			this.width = width;
			this.height = height;

			setPrice();
		}

		public override string ToString()
		{
			return base.GetType() + ": " + width + " inch by " + height + " inch, Price: " + price.ToString("C") ;
		}


	}
}
