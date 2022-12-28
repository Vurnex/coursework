using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppLab6P3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            BackgroundColor = Color.White;

            Title = "Flight Information";

            Label homeLabel = new Label
            {
                Text = "Flights",
                FontSize = 40,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            StackLayout contentLayout = new StackLayout()
            {
                Children = { }
            };

            Content = contentLayout;

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

        }

    }
}
