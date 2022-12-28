using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab8
{
    public partial class Form1 : Form
    {
        localhost.WebService1 proxy = new localhost.WebService1();

        DataTable dt2 = new DataTable();


        public Form1()
        {
            InitializeComponent();
            //dt2 = proxy.getManufacturerList();

            //listBox1.DataSource = dt2.ToString();

            //dataGridView1.DataSource = dt2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = dt2.Rows.Count;

            if (comboBox1.SelectedIndex == 0)
            {
                dt2 = proxy.getManufacturerList();
                dataGridView1.DataSource = dt2;

                listBox1.Items.Clear();

                for (int i = 0; i < count; i++)
                {

                    listBox1.Items.Add(dt2.Rows[i][0].ToString());

                }
                
            }
            else if (comboBox1.SelectedIndex == 1)
            {

                dt2 = proxy.getModelSizeList();
                dataGridView1.DataSource = dt2;

                listBox1.Items.Clear();

                for (int i = 0; i < count; i++)
                {

                    listBox1.Items.Add(dt2.Rows[i][0].ToString());

                }


            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dt2 = proxy.getDrones();
                dataGridView1.DataSource = dt2;

                listBox1.Items.Clear();

                for (int i = 0; i < count; i++)
                {

                    listBox1.Items.Add(dt2.Rows[i][0].ToString());

                }

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = listBox1.SelectedIndex;
            dt2 = proxy.getSelectedIndex(selectedItem);
            dataGridView1.DataSource = dt2;

        }
    }
}
