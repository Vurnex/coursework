/* 

	Laquon Hamilton
	ITS-245
	11/14/20
	Quiz 8
	

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
using System.IO;

namespace Quiz8
{
    public partial class FileIOProgram : Form
    {
        private DataTable dt;


        public FileIOProgram()
        {
            InitializeComponent();
        }

        private void FileIOProgram_Load(object sender, EventArgs e)//may need to be placed after addRecordButton constructor
        {

            dt = new DataTable();
            DataColumn column;

            // Create new DataColumn, set DataType,
            // ColumnName and add to DataTable.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FirstName";
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LastName";
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Age";
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            dt.Columns.Add(column);

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = dt.Columns["FirstName"];
            dt.PrimaryKey = PrimaryKeyColumns;

            dataGridView1.DataSource = dt;
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();

            pathTextBox.Text = folderDialog.SelectedPath;
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            DataRow row;

            row = dt.NewRow();
            row["FirstName"] = firstNameTextBox.Text;
            row["LastName"] = lastNameTextBox.Text;
            row["Age"] = Convert.ToInt32(ageTextBox.Text);
            dt.Rows.Add(row);

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            ageTextBox.Text = "";

            if (dt.Rows.Count >= 1 && fileNameTextBox.Text.Length >= 1)
            {
                saveFileButton.Show();
                saveFileButton.Enabled = true;
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            const string DELIM = ",";
            string fileName = pathTextBox.Text + "\\" + fileNameTextBox.Text;

            Faculty faculty = new Faculty();

            FileStream outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(outFile);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                faculty.FirstName = dt.Rows[i]["FirstName"].ToString();
                faculty.LastName = dt.Rows[i]["LastName"].ToString();
                faculty.Age = Convert.ToInt32(dt.Rows[i]["Age"].ToString());

                writer.WriteLine(faculty.FirstName + DELIM + faculty.LastName + DELIM + faculty.Age);
            }

            writer.Close();
            outFile.Close();
        }
    }

    class Faculty
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
