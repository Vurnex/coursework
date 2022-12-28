using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace AppLab7
{
    public class SecondPage : ContentPage
    {
        protected SQLiteConnection myDatabase;
        public SecondPage()
        {
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();

            myDatabase.CreateTable<TripInfo>();

            TripInfo rentalExpenses = new TripInfo { Ticket = "Rental", Expense = "Car Rental: $300" };

            myDatabase.Insert(rentalExpenses);

            var expense = myDatabase.Query<TripInfo>("SELECT * FROM TripInfo WHERE Ticket = 'Rental' ");

            Label rentalExpense = new Label()
            {
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            rentalExpense.Text = expense.First().Expense;

            StackLayout stack = new StackLayout()
            {
                Children = { rentalExpense }
            };

            Content = stack;


            Padding = new Thickness(0, Device.OnPlatform(20, 20, 0), 0, 0);
        }
    }
}