using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppLab6P3
{
    public class FirstPage : ContentPage
    {
        public FirstPage()
        {
            Label flightTicket = new Label()
            {
                Text = "Ticket: $150",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            StackLayout stack = new StackLayout()
            {
                Children = { flightTicket }
            };

            Content = stack;


            Padding = new Thickness(0, Device.OnPlatform(20, 20, 0), 0, 0);

        }
    }
}