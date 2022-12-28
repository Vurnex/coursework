using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Configuration;
using Microsoft.Data.Sqlite;
using System.Xml;
using System.Data.SQLite;

namespace WebApplicationLab8
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataTable getSelectedIndex(int selectedIndex)
        {
            SQLiteConnection sqlite_conn 
                = new SQLiteConnection("Data Source= C:\\Users\\Laquon\\Documents\\Homework\\ITS-462\\Lab 5\\lab5database.db;Version=3");

            sqlite_conn.Open();
            SQLiteCommand cmd;

            cmd = sqlite_conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM NewDrones WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", selectedIndex);

            SQLiteDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);

            return dt;

            //return "Hello World";
        }

        [WebMethod]
        public DataTable getManufacturerList()
        {
            SQLiteConnection sqlite_conn 
                = new SQLiteConnection("Data Source= C:\\Users\\Laquon\\Documents\\Homework\\ITS-462\\Lab 8\\lab5database.db;Version=3");

            sqlite_conn.Open();
            SQLiteCommand cmd;

            cmd = sqlite_conn.CreateCommand();
            cmd.CommandText = "SELECT Manufacturer FROM NewDrones";

            SQLiteDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);

            return dt;

        }

        [WebMethod]
        public DataTable getModelSizeList()
        {
            SQLiteConnection sqlite_conn
                = new SQLiteConnection("Data Source= C:\\Users\\Laquon\\Documents\\Homework\\ITS-462\\Lab 8\\lab5database.db;Version=3");

            sqlite_conn.Open();
            SQLiteCommand cmd;

            cmd = sqlite_conn.CreateCommand();
            cmd.CommandText = "SELECT Size FROM NewDrones";

            SQLiteDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);

            return dt;

        }

        [WebMethod]
        public DataTable getDrones()
        {
            SQLiteConnection sqlite_conn
                = new SQLiteConnection("Data Source= C:\\Users\\Laquon\\Documents\\Homework\\ITS-462\\Lab 8\\lab5database.db;Version=3");

            sqlite_conn.Open();
            SQLiteCommand cmd;

            cmd = sqlite_conn.CreateCommand();
            cmd.CommandText = "SELECT Model FROM NewDrones";

            SQLiteDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);

            return dt;

        }


    }
}
