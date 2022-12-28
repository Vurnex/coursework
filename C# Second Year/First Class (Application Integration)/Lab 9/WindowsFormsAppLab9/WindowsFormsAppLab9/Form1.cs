using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab9
{
    public partial class Form1 : Form
    {
        DataTable dt2 = new DataTable();

        ServiceReference1.Service1Client MyClient = new ServiceReference1.Service1Client();

        ServiceReference1.Drones drone = new ServiceReference1.Drones();

        ServiceReference1.Drones index = new ServiceReference1.Drones();

        public Form1()
        {
            InitializeComponent();

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;

            if (comboBox1.SelectedIndex == 0)
            {
                drone = MyClient.getManufacturerList();
                dt2 = drone.DroneTable;

                dataGridView1.DataSource = dt2;

                count = dt2.Rows.Count;

                listBox1.Items.Clear();

                for (int i = 0; i < count; i++)
                {

                    listBox1.Items.Add(dt2.Rows[i][0].ToString());

                }

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                drone = MyClient.getModelSizeList();
                dt2 = drone.DroneTable;

                dataGridView1.DataSource = dt2;

                count = dt2.Rows.Count;

                listBox1.Items.Clear();

                for (int i = 0; i < count; i++)
                {

                    listBox1.Items.Add(dt2.Rows[i][0].ToString());

                }

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                drone = MyClient.getDrones();
                dt2 = drone.DroneTable;

                dataGridView1.DataSource = dt2;

                count = dt2.Rows.Count;

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

            index = MyClient.getSelectedIndex(selectedItem);

            dt2 = index.DroneTable;

            dataGridView1.DataSource = dt2;

        }
    }
}
