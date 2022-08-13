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
	class PhotoDemo
	{
		static void Main(string[] args)
		{

			Photo photo1 = new Photo(8.0, 10.0);
			Photo photo2 = new Photo();
			photo2.Width = 10.0;
			photo2.Height = 12.0;

			Photo photo3 = new Photo(15.0, 16.0);

			FramedPhoto f_photo1 = new FramedPhoto(8, 10, "Wooden |", "Modern | ");

			FramedPhoto f_photo2 = new FramedPhoto();
			f_photo2.setFramedPhotoDimension(10, 20);
			f_photo2.Material = "Wooden |";
			f_photo2.Style = "Contemporary | ";

			MattedPhoto m_photo1 = new MattedPhoto(8, 10, "Bright | ");
			MattedPhoto m_photo2 = new MattedPhoto();
			m_photo2.setMattedPhotoDimension(10, 12);

			Console.WriteLine(photo1.ToString());
			Console.WriteLine(photo2.ToString());
			Console.WriteLine(photo3.ToString());

			Console.WriteLine(f_photo1.ToString());
			Console.WriteLine(f_photo2.ToString());

			Console.WriteLine(m_photo1.ToString());
			Console.WriteLine(m_photo2.ToString());

			Console.ReadKey();
		}
	}
	
}
