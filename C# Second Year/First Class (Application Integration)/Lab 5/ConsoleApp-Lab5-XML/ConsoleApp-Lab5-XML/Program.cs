using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Xml;
using System.Data.SQLite;

namespace ConsoleApp_Lab5_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beginning operations...\n");

            SqliteConnection conn = new SqliteConnection();

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();

            CreateTable(sqlite_conn);

            InsertData(sqlite_conn);

            Console.Write("Finished.");

        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            
            // Create a new database connection:
            
            sqlite_conn = 
                new SQLiteConnection("Data Source= C:\\Users\\Laquon\\Documents\\Homework\\ITS-462\\Lab 5\\lab5database.db;Version=3");
            
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to open a connection.", ex.Message);

                Environment.Exit(1);
            }
                return sqlite_conn;
        }

        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = @"CREATE TABLE IF NOT EXISTS 
                                 NewDrones 
                                 (Manufacturer VARCHAR(20), Model VARCHAR(20), 
                                  Price VARCHAR(20), Time VARCHAR(20), Size VARCHAR(20));";

            try
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = Createsql;
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to create the table. \nError: {0}", e.Message);

                Environment.Exit(1);
            }



        }

        static void InsertData(SQLiteConnection conn)
        {
            string manufacturer, model, price, time, size;

            //Grab data from XML file
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\Users\\Laquon\\Documents\\Homework\\ITS-462\\Lab 5\\lab5.xml");

            XmlNodeList dataNodes = xmlDoc.SelectNodes("/table/trow");

            foreach (XmlNode node in dataNodes)
            {
                manufacturer = node.SelectSingleNode("Manufacturer").InnerText;
                model = node.SelectSingleNode("Model").InnerText;
                price = node.SelectSingleNode("Price").InnerText;
                time = node.SelectSingleNode("Time").InnerText;
                size = node.SelectSingleNode("Size").InnerText;

                //Insert the XML data into the database table

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();

                sqlite_cmd.CommandText = @"INSERT INTO NewDrones (Manufacturer, Model, Price, Time, Size)
                                           VALUES($manufacturer, $model, $price, $time, $size)
                                         ";

                sqlite_cmd.Parameters.AddWithValue("$manufacturer", manufacturer);
                sqlite_cmd.Parameters.AddWithValue("$model", model);
                sqlite_cmd.Parameters.AddWithValue("$price", price);
                sqlite_cmd.Parameters.AddWithValue("$time", time);
                sqlite_cmd.Parameters.AddWithValue("$size", size);

                sqlite_cmd.ExecuteNonQuery();

            }

        }
    }
}
