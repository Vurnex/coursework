using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace AppLab7
{
    public partial class MainPage : ContentPage
    {
        protected SQLiteConnection myDatabase;

        public MainPage()
        {
            InitializeComponent();

            /*

            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();

            myDatabase.CreateTable<Item>();

            // Change these below. Also change them in the Item file.

            var item = new Item { Name = "First", Description = "This is the first item" };
            var item2 = new Item { Name = "Second", Description = "This is the second item" };

            myDatabase.Insert(item);
            myDatabase.Insert(item2);

            // Retrieve database item either by Get method or Query (SQL) method
            var item3 = myDatabase.Get<Item>(1);

            // Alternate way of retrieving record info from the Item table in SQLite.
            var firstItem = myDatabase.Query<Item>("SELECT * FROM Item WHERE Name = 'First' ");
            var secondItem = myDatabase.Query<Item>("SELECT * FROM Item WHERE Name = 'Second' ");

            Label labelWelcome = new Label
            {
                Text = "SQLite database connectivity example"
            };
            Label label1 = new Label { };
            Label label2 = new Label { };
            Label label3 = new Label { };
            Label label4 = new Label { };
            Label label5 = new Label { };
            Label label6 = new Label { };

            // Get database Item Name and copy into label.
            label1.Text = item3.Name;
            label2.Text = item3.Description;
            label3.Text = firstItem.First().Name;
            label4.Text = firstItem.First().Description;
            label5.Text = secondItem.First().Name;
            label6.Text = secondItem.First().Description;

            StackLayout stacklayout1 = new StackLayout
            {
                Children =
                {
                    labelWelcome,
                    label1,
                    label2,
                    label3,
                    label4,
                    label5,
                    label6
                }
            };

            Content = stacklayout1;

            */

        }
    }
}
