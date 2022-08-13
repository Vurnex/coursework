/* 

	Laquon Hamilton
	ITS-245
	12/15/20
	Final Exam
	Question 1, 2

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamLH
{
	class CustomerAddress
	{
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }

		public CustomerAddress(string City, string State, string ZipCode)
		{
			this.City = City;
			this.State = State;
			this.ZipCode = ZipCode;
		}
		
	}

}
