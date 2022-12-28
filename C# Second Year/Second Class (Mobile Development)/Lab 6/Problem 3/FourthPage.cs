using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppLab6P3
{
    public class FourthPage : ContentPage
    {
        public FourthPage()
        {
            Label breakfastExpense = new Label()
            {
                Text = "Breakfast: $13",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Label lunchExpense = new Label()
            {
                Text = "Lunch: $15",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Label dinnerExpense = new Label()
            {
                Text = "Dinner: $26",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Label totalExpense = new Label()
            {
                Text = "Total: $54",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            StackLayout stack = new StackLayout()
            {
                Children = { breakfastExpense, lunchExpense, dinnerExpense, totalExpense }
            };

            Content = stack;


            Padding = new Thickness(0, Device.OnPlatform(20, 20, 0), 0, 0);
        }
    }
}