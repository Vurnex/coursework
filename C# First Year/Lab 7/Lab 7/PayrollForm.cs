/* 

	Laquon Hamilton
	ITS-245
	10/24/20
	Lab 7
	Problem 1

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class PayRollGUI : Form
    {
        private double hourlyPay;
        private double hoursWorked;
        private double grossPay;
        private double fedTax;
        private double stateTax;
        private double netPay;

        const double FED_TAX_RATE = 0.15;
        const double STATE_TAX_RATE = 0.05;

        public PayRollGUI()
        {
            InitializeComponent();
        }

        private void PayRollGUI_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Double.TryParse(hourlyPayText.Text, out hourlyPay);
            Double.TryParse(hoursWorkedText.Text, out hoursWorked);

            grossPay = hourlyPay * hoursWorked;
            fedTax = grossPay * FED_TAX_RATE;
            stateTax = grossPay * STATE_TAX_RATE;
            netPay = grossPay - fedTax - stateTax;

            displayGrossPay.Text = grossPay.ToString("C");
            displayFedTax.Text = fedTax.ToString("C");
            displayStateTax.Text = stateTax.ToString("C");
            displayNetPay.Text = netPay.ToString("C");

            displayGrossPay.Visible = true;
            displayFedTax.Visible = true;
            displayStateTax.Visible = true;
            displayNetPay.Visible = true;
        }
    }
}
