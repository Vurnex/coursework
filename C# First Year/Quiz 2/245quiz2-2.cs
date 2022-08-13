/* 
	
	Laquon Hamilton
	ITS-245
	9/10/20
	Quiz 2

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Quiz_2
{
	class Computer
	{
		
		private string manufacturer;
		private string modelNumber;
		private double price;

		public string Manufacturer 
		{ 
			get => manufacturer; 
			set => manufacturer = value;
		}
		
		public string ModelNumber 
		{ 
			get => modelNumber; 
			set => modelNumber = value;
		}
		
		public double Price 
		{ 
			get => price; 
			set => price = value;
		}
		
		public void displayComputer()
		{
			Console.WriteLine("\nComputer Manufacturer: {0}", manufacturer);
			Console.WriteLine("\nComputer Model: {0}", modelNumber);
			Console.WriteLine("\nComputer Price: ${0}", price);
		}
				
	}
		
}

