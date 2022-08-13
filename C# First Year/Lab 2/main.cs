/* 
	
	Laquon Hamilton
	ITS-245
	9/3/20
	Lab 2

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_2
{
	class Program
	{
		
		static void Main(string[] args)
		{

			Console.Clear();

			Console.WriteLine("\nProgram that allows the user to enter information about a phone.");

			string manufacturer = " ";
			string model = " "; 
			bool hasCord = true; 
			double price = 0;

			Program.inputPhone(ref manufacturer, ref model, ref hasCord, ref price);
			Console.ReadLine();

		}

		static void inputPhone(ref string manufacturer, ref string model, ref bool hasCord, ref double price)
		{

			int i = 0;

			string[] manufacturers = new string[100];
			string[] models = new string[100];
			bool[] hasCords = new bool[100];
			double[] prices = new double[100];
			int numberOfPhones = i;

			string enterMore = "Y";

			do
			{
				Console.Write("\nPlease enter the phone manufacturer: ");
				manufacturer = Console.ReadLine();
				manufacturers[i] = manufacturer;

				Console.Write("\nPlease enter the phone model: ");
				model = Console.ReadLine();
				models[i] = model;

				Console.Write("\nPlease enter the phone price: ");
				string inputPrice = Console.ReadLine();
				price = Convert.ToDouble(inputPrice);
				prices[i] = price;
				
				Console.Write("\nIs the phone cordless? ");
				string YN = Console.ReadLine();

				if (YN == "Y")
				{
					hasCord = true;
					hasCords[i] = hasCord;
				}
				else if (YN == "N")
				{
					hasCord = false;
					hasCords[i] = hasCord;
				}
				else if (YN != "Y" || YN != "N")
				{
					Console.WriteLine("\nPlease enter Y or N");
					Console.Write("\nIs the phone cordless? ");
					YN = Console.ReadLine();
				}

				Console.Write("\nWould you like to enter another phone? ");
				enterMore = Console.ReadLine();

				i++;

				Console.Clear();

			} while (enterMore != "N");

			numberOfPhones = i;

			Program.outputPhones(manufacturers, models, hasCords, prices, numberOfPhones);

		}

		static void outputPhones(string[] manufacturers, string[] models, bool[] hasCords, double[] prices, int numberOfPhones)
		{

			int i;

			for (i = 0; i < numberOfPhones; i++)
			{
				Console.WriteLine("\nPhone #{0} \n----------- \nManufacturer: {1} \nModel: {2} \nPrice: ${3}", i + 1, manufacturers[i], models[i], prices[i]);

				if (hasCords[i] == true)
				{
					Console.WriteLine("Cordless: Yes");
				}
				else if (hasCords[i] == false)
				{
					Console.WriteLine("Cordless: No");
				}
			
			}

			Console.WriteLine("\n----------- \nTotal Number of Phones Stored: {0}", numberOfPhones);

		}

	}
		
}

