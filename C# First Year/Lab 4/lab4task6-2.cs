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
	class Employee
	{
		private string employeeName;
		private int employeeID;

		public string EmployeeName { get => employeeName; set => employeeName = value; }

		public int EmployeeID { get => employeeID; set => employeeID = value; }

		public Employee()
		{
			employeeName = " ";
			employeeID = 0;
		}

    public Employee(string employeeName, int employeeID)
		{
			this.employeeName = employeeName;
			this.employeeID = employeeID;
		}
  }
}
