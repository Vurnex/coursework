/* 

	Laquon Hamilton
	ITS-245
	10/23/20
	Quiz 6


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

namespace Quiz6v2
{
    public partial class Form1 : Form
    {
        private string[] values = {"1", "2", "3", "4", "5"};
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            valueList.Items.AddRange(values);
        }
        private void valueList_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueLabel.Text = valueList.SelectedItem.ToString() + " is selected";
            valueLabel.Visible = true;
        }

        private void valueLabel_Click(object sender, EventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            buttonLabel.Text = "You clicked the button.";
            buttonLabel.Visible = true;
        }

        private void buttonLabel_Click(object sender, EventArgs e)
        {

        }

        private void testButton_MouseLeave(object sender, EventArgs e)
        {
            buttonLabel.Text = "";
            buttonLabel.Visible = false;
        }
    }
}
