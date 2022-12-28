using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SQLite;

namespace WcfServiceLibraryLab9
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source= C:\\Users\\Laquon\\Documents\\Homework\\ITS-462\\Lab 8\\lab5database.db;Version=3");
        SQLiteCommand cmd;
        SQLiteDataAdapter sda;
        SQLiteDataReader reader;
        DataTable dt;
        Drones drone = new Drones();

        public Drones getSelectedIndex(int selectedIndex)
        {
            using (sqlite_conn)
            {
                sqlite_conn.Open();
                cmd = sqlite_conn.CreateCommand();

                cmd.CommandText = "SELECT * FROM NewDrones WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", selectedIndex + 1);

                sda = new SQLiteDataAdapter(cmd);

                dt = new DataTable("Drones");

                sda.Fill(dt);

                drone.DroneTable = dt;

                sqlite_conn.Close();

                return drone;
            }
        }

        public Drones getManufacturerList()
        {

            using (sqlite_conn)
            {
                sqlite_conn.Open();
                cmd = sqlite_conn.CreateCommand();

                cmd.CommandText = "SELECT Manufacturer FROM NewDrones";

                sda = new SQLiteDataAdapter(cmd);

                dt = new DataTable("Drones");

                sda.Fill(dt);

                drone.DroneTable = dt;

                sqlite_conn.Close();

                return drone;
            }

        }

        public Drones getModelSizeList()
        {

            using (sqlite_conn)
            {
                sqlite_conn.Open();
                cmd = sqlite_conn.CreateCommand();

                cmd.CommandText = "SELECT Size FROM NewDrones";

                sda = new SQLiteDataAdapter(cmd);

                dt = new DataTable("Drones");

                sda.Fill(dt);

                drone.DroneTable = dt;

                sqlite_conn.Close();

                return drone;
            }

        }

        public Drones getDrones()
        {

            using (sqlite_conn)
            {
                sqlite_conn.Open();
                cmd = sqlite_conn.CreateCommand();

                cmd.CommandText = "SELECT Model FROM NewDrones";

                sda = new SQLiteDataAdapter(cmd);

                dt = new DataTable("Drones");

                sda.Fill(dt);

                drone.DroneTable = dt;

                sqlite_conn.Close();

                return drone;
            }

        }


        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
