using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace AppLab7
{

    public class FirstPage : ContentPage
    {
        protected SQLiteConnection myDatabase;
        public FirstPage()
        {
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();

            myDatabase.CreateTable<TripInfo>();

            TripInfo flightExpenses = new TripInfo { Ticket = "Flight", Expense = "Flight Ticket: $150" };

            myDatabase.Insert(flightExpenses);

            //var ticket = myDatabase.Get<TripInfo>(1);
            var ticket = myDatabase.Query<TripInfo>("SELECT * FROM TripInfo WHERE Ticket = 'Flight' ");

            Label flightTicket = new Label()
            {
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            flightTicket.Text = ticket.First().Expense;

            StackLayout stack = new StackLayout()
            {
                Children = { flightTicket }
            };

            Content = stack;


            Padding = new Thickness(0, Device.OnPlatform(20, 20, 0), 0, 0);

        }
    }
}