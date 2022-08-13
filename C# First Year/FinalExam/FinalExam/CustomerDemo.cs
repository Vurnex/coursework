/* 

	Laquon Hamilton
	ITS-245
	12/16/20
	Final Exam
	Question 1, 2, 3, 4, 5

*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;

namespace FinalExamLH
{
	class CustomerDemo
	{
		static void Main(string[] args)
		{

			//Console.Clear();

			//Question 1

			Console.WriteLine("-----Question 1-----\n");

			CustomerAddress address1 = new CustomerAddress("Napoleonland", "MN", " 69045");

			Customer c1 = new Customer();

			c1.CustomerID = "14509";
			c1.CustomerName = "Garry Gibson";
			c1.Address = address1;

			Customer c2 = new Customer("21973", "Ida McDermott", address1);

			Console.WriteLine("Data written to objects\n");

			//Question 2

			Console.WriteLine("-----Question 2-----\n");

			DisplayCustomer(c1);
			c2.DisplayCustomerInfo();

			//Question 3

			Console.WriteLine("-----Question 3-----\n");

			string directory = "C:\\Users\\hamil133\\Documents\\FinalExam";
			const string OUTPUTFILENAME = "Customers.txt";
			const char DELIM = ',';
			Customer[] customerArray = new Customer[3];
			string fullpath = directory + "\\" + OUTPUTFILENAME;

			CustomerAddress address2 = new CustomerAddress("West Austynport", "KS ", "86690");


			customerArray[0] = new Customer("49716", "Aisha Hirthe", address1);
			customerArray[1] = new Customer("91235", "Diana Herman", address1);
			customerArray[2] = new Customer("56490", "Paolo Klocko", address2);

			if (!Directory.Exists(directory))
			{
				Directory.CreateDirectory(directory);
			}

			Console.WriteLine();
			Console.WriteLine("Writing to file...\n");

			try
			{
				FileStream outputFile = new FileStream(fullpath, FileMode.Create, FileAccess.Write);
				StreamWriter writer = new StreamWriter(outputFile);

				for (int i = 0; i < customerArray.Length; i++)
				{
					writer.WriteLine(customerArray[i].CustomerID + DELIM + customerArray[i].CustomerName + DELIM
						+ customerArray[i].Address.City + DELIM + customerArray[i].Address.State + DELIM + customerArray[i].Address.ZipCode);
				}

				writer.Close();
				outputFile.Close();

				Console.WriteLine("\nFinished\n");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error\n", ex.Message);
			}

			//Question 4

			Console.WriteLine("-----Question 4-----\n");

			const string INFILENAME = "C:\\Users\\hamil133\\Documents\\FinalExam\\Customers.txt";
			string[] customers = new string[3];
			string recordIn;

			FileStream inFile = new FileStream(INFILENAME, FileMode.Open, FileAccess.Read);
			StreamReader reader = new StreamReader(inFile);

			Console.WriteLine();
			Console.WriteLine("Reading file...\n");

			int j = 0;
			recordIn = reader.ReadLine();

			while (recordIn != null)
			{
				customers[j] = recordIn;
				Console.WriteLine(customers[j]);
				j++;
				recordIn = reader.ReadLine();
			}

			Console.WriteLine("\nFinished\n");

			//Question 5

			Console.WriteLine("-----Question 5-----\n");

			string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hamil133\\Documents\\FinalExam\\CustomersDatabase.accdb";
			string strSQL = "SELECT * FROM CustomerTable";
			// Create a connection    
			using (OleDbConnection connection = new OleDbConnection(connectionString))
			{
				// Create a command and set its connection    
				OleDbCommand command = new OleDbCommand(strSQL, connection);
				// Open the connection and execute the select command.    
				try
				{
					Console.WriteLine("Reading from database...\n");
					// Open connecton    
					connection.Open();
					// Execute command    
					OleDbDataReader dBReader = command.ExecuteReader();
					{
						while (dBReader.Read())
                        {
							Console.Write(dBReader[0].ToString() + ", ");
							Console.Write(dBReader[1].ToString() + ", ");
							Console.Write(dBReader[2].ToString());
							Console.WriteLine();
						}
					}


				}
				catch (Exception ex)
				{
					Console.WriteLine("Error\n", ex.Message);
				}

				Console.WriteLine("\nFinished\n");
			}

			Console.ReadKey();
		}

		public static void DisplayCustomer(Customer c)
		{
			Console.WriteLine("Customer #" + c.CustomerID + " is named " + c.CustomerName + ".\n");
			Console.WriteLine("The customer lives in " + c.Address.City + ", " + c.Address.State + "," + c.Address.ZipCode + ".\n");
		}
	}

}

