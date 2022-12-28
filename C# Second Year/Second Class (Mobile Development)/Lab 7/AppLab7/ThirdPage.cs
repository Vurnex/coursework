using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;
using SQLitePCL;

namespace AppLab7
{
    public class ThirdPage : ContentPage
    {
        protected SQLiteConnection myDatabase;
        public ThirdPage()
        {

            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();

            myDatabase.CreateTable<TripInfo>();

            TripInfo hotelExpenses = new TripInfo { Ticket = "Hotel", Expense = "Room Cost: $125" };

            myDatabase.Insert(hotelExpenses);

            var expense = myDatabase.Query<TripInfo>("SELECT * FROM TripInfo WHERE Ticket = 'Hotel' ");

            Label hotelExpense = new Label()
            {
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            hotelExpense.Text = expense.First().Expense;

            StackLayout stack = new StackLayout()
            {
                Children = { hotelExpense }
            };

            Content = stack;


            Padding = new Thickness(0, Device.OnPlatform(20, 20, 0), 0, 0);
        }
    }
}