/* 

	Laquon Hamilton
	ITS-245
	11/7/20
	Quiz 7
	

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

namespace Quiz_7
{
    public partial class DataBaseView : Form
    {
        public DataBaseView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void viewTableButton_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDatabaseDataSet.CustomerTable' table. You can move, or remove it, as needed.
            this.customerTableTableAdapter.Fill(this.customersDatabaseDataSet.CustomerTable);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.customerTableBindingSource.EndEdit();
            this.customerTableTableAdapter.Update(this.customersDatabaseDataSet.CustomerTable);
        }

        private void showNumsButton_Click(object sender, EventArgs e)
        {
            showNumsList.Items.Clear();

            phoneNumsLabel.Visible = true;

            var showCustomersPhone =
                from s in this.customersDatabaseDataSet.CustomerTable
                select s.customerPhone;

            foreach(var s in showCustomersPhone)
            {
                showNumsList.Items.Add(s);
            }
        }
    }
}
