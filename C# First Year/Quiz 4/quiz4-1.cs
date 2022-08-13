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
	class DisplayData
	{
		static void Main(string[] args)
		{

			Cube cube = new Cube(100.0, 200.0, 300.0);		
			
			Square sq = new Square(400.00, 400.0);

			sq.display();

			cube.display();

			Console.ReadKey();
		}
	}
	
}
