/* 

	Laquon Hamilton
	ITS-245
	10/1/20
	Quiz 5


*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5
{
	class Patient
	{
		private string id;
		private int age;
		private BloodData bloodData;
		private string phoneNum;
		private string eMail;
		private string nextOfKin;

		public string Id { get => id; set => id = value; }
		public int Age { get => age; set => age = value; }
		internal BloodData BloodData { get => bloodData; set => bloodData = value; }
    public string PhoneNum { get => phoneNum; set => phoneNum = value; }
		public string Email { get => eMail; set => eMail = value; }
		public string NextOfKin { get => nextOfKin; set => nextOfKin = value; }

		public Patient()
		{
			id = "0";
			bloodData = new BloodData();
			phoneNum = "";
			eMail = "";
			nextOfKin = "";
		}

		public Patient(string id, int age, BloodData bloodData, string phoneNum, string eMail, string nextOfKin)
		{
			this.id = id;
			this.age = age;
			this.bloodData = bloodData;
			this.phoneNum = phoneNum;
			this.eMail = eMail;
			this.nextOfKin = nextOfKin;
		}

		public void display()
		{
			Console.WriteLine("\nPatient ID: {0}, Age: {1}", id, age);
			Console.WriteLine("\nPatinet's ");
			bloodData.display();
			Console.WriteLine("\nPhone Number: {0} \nEmail: {1} \nNext of Kin: {2}", phoneNum, eMail, nextOfKin);
		}

	}
}
