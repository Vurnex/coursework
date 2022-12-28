using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppLab6P3
{
    public class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            Label hotelExpense = new Label()
            {
                Text = "Room cost: $125",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            StackLayout stack = new StackLayout()
            {
                Children = { hotelExpense }
            };

            Content = stack;


            Padding = new Thickness(0, Device.OnPlatform(20, 20, 0), 0, 0);
        }
    }
}