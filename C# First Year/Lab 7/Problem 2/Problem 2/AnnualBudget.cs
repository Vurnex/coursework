/* 

	Laquon Hamilton
	ITS-245
	10/26/20
	Lab 7
	Problem 2

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

namespace Problem_2
{
    public partial class AnnualBudget : Form
    {
        public AnnualBudget()
        {
            InitializeComponent();
        }

        private void websiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://www.youtube.com");
        }

        private void excelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\Users\hamil133\Documents\Lab 7\Problem 2\Problem 2\TestAnnualBudget.txt");
            System.Diagnostics.Process.Start(@"C:\Users\hamil133\Documents\Lab 7\Problem 2\Problem 2\AnnualBudget.xlsx");
            
        }
    }
}
