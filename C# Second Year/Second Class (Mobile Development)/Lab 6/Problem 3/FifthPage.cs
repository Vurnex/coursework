using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppLab6P3
{
    public class FifthPage : ContentPage
    {
        public FifthPage()
        {

            Label gasExpense = new Label()
            {
                Text = "Gas: $200",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Label tollExpense = new Label()
            {
                Text = "Toll Road: $10",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Label parkingExpense = new Label()
            {
                Text = "Parking (per hour): $7",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            StackLayout stack = new StackLayout()
            {
                Children = { gasExpense, tollExpense, parkingExpense }
            };

            Content = stack;


            Padding = new Thickness(0, Device.OnPlatform(20, 20, 0), 0, 0);
        }
    }
}