using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Lab1_Q1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label label = new Label
            {
                Text = "Testing label output",
                FontSize = 25,
                HorizontalOptions = LayoutOptions.Center
            };

            StackLayout stack1 = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    label
                }
            };

            this.Content = stack1;
        }
    }
}
