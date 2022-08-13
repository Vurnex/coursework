/* 
	
	Laquon Hamilton
	ITS-245
	9/21/20
	Lab 4
	Task 4

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_4
{
	class Schools : IComparable
	{
		private string schoolName;
		private string schoolDistrict;
		private int enrollSize;
		private int schoolAge;
		private int schoolID;
		private bool sortEnrollment;

		public string SchoolName { get => schoolName; set => schoolName = value; }
    public string SchoolDistrict { get => schoolDistrict; set => schoolDistrict = value; }
    public int EnrollSize { get => enrollSize; set => enrollSize = value; }
  	public int SchoolAge { get => schoolAge; set => schoolAge = value; }
  	public int SchoolID { get => schoolID; set => schoolID = value; }

    public static bool SortEnrollment { get; set; }
		
		public Schools()
		{
			schoolName = " ";
			schoolDistrict = " ";
			enrollSize = 0;
			schoolAge = 0;
			schoolID = 0;
			sortEnrollment = true;
		}

    public Schools(string schoolName, string schoolDistrict, int enrollSize, int schoolAge, int schoolID)
		{
			this.schoolName = schoolName;
			this.schoolDistrict = schoolDistrict;
			this.enrollSize = enrollSize;
			this.schoolAge = schoolAge;
			this.schoolID = schoolID;
			sortEnrollment = true;
		}

		public Schools(string schoolName, string schoolDistrict)
		{
			this.schoolName = schoolName;
			this.schoolDistrict = schoolDistrict;
		}

		int IComparable.CompareTo(object obj)
		{
			int returnValue = 1;
			Schools temp = (Schools)obj;

			if (this.EnrollSize > temp.EnrollSize)
			{
				returnValue = 1;
			}
			else if (this.EnrollSize < temp.EnrollSize)
			{
				returnValue = -1;
			}
			else
			{
				returnValue = 0;
			}
			
			return returnValue;
		}

  }
}
