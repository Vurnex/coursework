using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace AppLab7
{

    public class FifthPage : ContentPage
    {
        protected SQLiteConnection myDatabase;

        public FifthPage()
        {
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();

            myDatabase.CreateTable<TripInfo>();

            TripInfo gasExpenses = new TripInfo { Ticket = "Gas", Expense = "Gas: $200" };
            TripInfo tollExpenses = new TripInfo { Ticket = "Toll", Expense = "Toll Road: $10" };
            TripInfo parkingExpenses = new TripInfo { Ticket = "Parking", Expense = "Parking (per hour): $7" };

            myDatabase.Insert(gasExpenses);
            myDatabase.Insert(tollExpenses);
            myDatabase.Insert(parkingExpenses);

            var selectGasExpense = myDatabase.Query<TripInfo>("SELECT * FROM TripInfo WHERE Ticket = 'Gas' ");
            var selectTollExpense = myDatabase.Query<TripInfo>("SELECT * FROM TripInfo WHERE Ticket = 'Toll' ");
            var selectParkingExpense = myDatabase.Query<TripInfo>("SELECT * FROM TripInfo WHERE Ticket = 'Parking' ");

            Label gasExpense = new Label()
            {
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            gasExpense.Text = selectGasExpense.First().Expense;

            Label tollExpense = new Label()
            {
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            tollExpense.Text = selectTollExpense.First().Expense;

            Label parkingExpense = new Label()
            {
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            parkingExpense.Text = selectParkingExpense.First().Expense;

            StackLayout stack = new StackLayout()
            {
                Children = { gasExpense, tollExpense, parkingExpense }
            };

            Content = stack;


            Padding = new Thickness(0, Device.OnPlatform(20, 20, 0), 0, 0);
        }
    }
}