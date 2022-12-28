using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SQLite;

namespace AppLab7
{
    public class FourthPage : ContentPage
    {
        protected SQLiteConnection myDatabase;
        public FourthPage()
        {
            myDatabase = DependencyService.Get<IDatabase>().ConnectToDB();

            myDatabase.CreateTable<TripInfo>();

            TripInfo breakfastExpenses = new TripInfo { Ticket = "Breakfast", Expense = "Breakfast: $13" };
            TripInfo lunchExpenses = new TripInfo { Ticket = "Lunch", Expense = "Lunch: $15" };
            TripInfo dinnerExpenses = new TripInfo { Ticket = "Dinner", Expense = "Dinner: $26" };
            TripInfo totalExpenses = new TripInfo { Ticket = "Total", Expense = "Total: $54" };

            myDatabase.Insert(breakfastExpenses);
            myDatabase.Insert(lunchExpenses);
            myDatabase.Insert(dinnerExpenses);
            myDatabase.Insert(totalExpenses);

            var selectBreakfastExpense = myDatabase.Query<TripInfo>("SELECT * FROM TripInfo WHERE Ticket = 'Breakfast' ");
            var selectLunchExpense = myDatabase.Query<TripInfo>("SELECT * FROM TripInfo WHERE Ticket = 'Lunch' ");
            var selectDinnerExpense = myDatabase.Query<TripInfo>("SELECT * FROM TripInfo WHERE Ticket = 'Dinner' ");
            var selectTotalExpense = myDatabase.Query<TripInfo>("SELECT * FROM TripInfo WHERE Ticket = 'Total' ");

            Label breakfastExpense = new Label()
            {
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            breakfastExpense.Text = selectBreakfastExpense.First().Expense;

            Label lunchExpense = new Label()
            {
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            lunchExpense.Text = selectLunchExpense.First().Expense;

            Label dinnerExpense = new Label()
            {
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            dinnerExpense.Text = selectDinnerExpense.First().Expense;

            Label totalExpense = new Label()
            {
                Text = "Total: $54",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            totalExpense.Text = selectTotalExpense.First().Expense;

            StackLayout stack = new StackLayout()
            {
                Children = { breakfastExpense, lunchExpense, dinnerExpense, totalExpense }
            };

            Content = stack;


            Padding = new Thickness(0, Device.OnPlatform(20, 20, 0), 0, 0);
        }
    }
}