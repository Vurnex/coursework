using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppLab6P3
{
    public class SecondPage : ContentPage
    {
        public SecondPage()
        {
            Label rentalExpense = new Label()
            {
                Text = "Car Rental: $300",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            StackLayout stack = new StackLayout()
            {
                Children = { rentalExpense }
            };

            Content = stack;


            Padding = new Thickness(0, Device.OnPlatform(20, 20, 0), 0, 0);
        }
    }
}