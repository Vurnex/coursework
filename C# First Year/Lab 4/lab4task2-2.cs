/* 
	
	Laquon Hamilton
	ITS-245
	9/20/20
	Lab 4
	Task 2

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_4
{
	class SalesTransaction
	{
		private string salespersonName;
		private double salesAmount;
		private double commission;
		readonly double commissionRate;

		public string SalespersonName { get => salespersonName; set => salespersonName = value; }
		public double SalesAmount { get => salesAmount; set => salesAmount = value; }
		public double Commission { get => commission; }

		public double CommissionRate { get => commissionRate; }

		public SalesTransaction(string salespersonName, double salesAmount, double commissionRate)
		{
			this.salespersonName = salespersonName;
			this.salesAmount = salesAmount;
			this.commissionRate = commissionRate;

			this.commission = salesAmount * commissionRate;
		}

		public SalesTransaction(string salespersonName, double salesAmount)
		{
			this.salespersonName = salespersonName;
			this.salesAmount = salesAmount;
			this.commissionRate = 0;
			this.commission = 0;
		}

		public SalesTransaction(string salespersonName)
		{
			this.salespersonName = salespersonName;
			this.salesAmount = 0;
			this.commissionRate = 0;
			this.commission = 0;
		}

		public double getTotalPrice()
		{
			return salesAmount + commission;
		}

  }
}
