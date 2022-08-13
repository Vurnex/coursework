/* 
	
	Laquon Hamilton
	ITS-245
	9/3/20
	Quiz 1

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, depth, volume;

            string inputStr;

						Console.Clear();

            Console.Write("\n1. Please input the length of the cube: ");
            //Console.Write("The length of first edge:");
            inputStr = Console.ReadLine();
            length = Convert.ToDouble(inputStr);
           
            Console.Write("\n2. Please input the width of the cube: ");
            inputStr = Console.ReadLine();
            width = Convert.ToDouble(inputStr);

            Console.Write("\n3. Please input the depth of the cube: ");
            inputStr = Console.ReadLine();
            depth = Convert.ToDouble(inputStr);

						volume = length * width * depth; //4.

						Console.WriteLine("\nLength: {0}, Width: {1}, Depth: {2}, Volume: {3}", length, width, depth, volume); //5.

						if(volume > 100) //6.
						{
							Console.WriteLine("\nThe cube is big.\n");
						}
						else if(volume > 50 && volume < 100) //7.
						{
							Console.WriteLine("\nThe cube is average in size.\n");
						}
						else if(volume < 50) //8.
						{
							Console.WriteLine("\nThe cube is small.\n");
						}

            Console.ReadLine();

						
        }
    }
}