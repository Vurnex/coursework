using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SQLite;
using System.IO; // Needed for the "Path" class reference.
using AppLab7.Droid; // Needed for reference to "Android_DB_Connection" in the assembly.
using Xamarin.Forms; // Needed for the "Dependency" reference in assembly.

[assembly: Dependency(typeof(AndroidDBConnection))]

namespace AppLab7.Droid
{
    class AndroidDBConnection : IDatabase
    {
        public AndroidDBConnection() { }

        public SQLiteConnection ConnectToDB()
        {
            var filename = "androidDBlab7.db";
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, filename);
            var connection = new SQLiteConnection(path);
            Console.WriteLine("DB Path = " + path);
            return connection;

        }
    }
}