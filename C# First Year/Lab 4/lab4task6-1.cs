/* 
	
	Laquon Hamilton
	ITS-245
	9/22/20
	Lab 4
	Task 6

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_4
{
	class ArrayOfObjects
	{
		static void Main(string[] args)
		{
			int i = 0;
			int currentEmployee = 1;

			Employee [] myEmployeeArray = new Employee[10];

			for (i = 0; i < myEmployeeArray.Length; i++)
			{
				myEmployeeArray[i] = new Employee();
			}

			myEmployeeArray[0] = new Employee("Arnold Fox", 111);
			myEmployeeArray[1] = new Employee("Jamie Yates", 100);

			for (i = 0; i < 2; i++)
			{
				Console.WriteLine("\nEmployee {0}: {1} | ID: {2}", currentEmployee, myEmployeeArray[i].EmployeeName, myEmployeeArray[i].EmployeeID);

				currentEmployee++;
			}

		}


	}
	
	
}
