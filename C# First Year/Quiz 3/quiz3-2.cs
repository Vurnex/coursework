/* 
	
	Laquon Hamilton
	ITS-245
	9/17/20
	Quiz 3

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Quiz_3
{
    class DisplayCar
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Impala", 2020);
            myCar.Mpg = 28;

            Console.WriteLine("\nModel: {0}", myCar.Model);
            Console.WriteLine("\nYear: {0}", myCar.Year);
            Console.WriteLine("\nMpg: {0}", myCar.Mpg);

            Console.ReadKey();


        }
    }
}
