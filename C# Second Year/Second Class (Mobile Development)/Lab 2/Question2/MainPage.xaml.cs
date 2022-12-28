using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Lab2_Q2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            RelativeLayout relativeLayout = new RelativeLayout();

            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(0,0,0,20),

                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto }, //prevent save button from expanding
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                }

            };

            BackgroundColor = Color.Orange;

            grid.Children.Add(new Label
            {

                Text = "Register",
                FontSize = 32,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center

            }, 1, 1);

            //---

            grid.Children.Add(new Label
            {

                Text = "First Name",
                FontSize = 20,
                TextColor = Color.White

            }, 1, 2);

            grid.Children.Add(new Entry
            {
                Placeholder = "e.g. John",

            }, 1, 3);

            //---

            grid.Children.Add(new Label
            {

                Text = "Last Name",
                FontSize = 20,
                TextColor = Color.White

            }, 1, 4);

            grid.Children.Add(new Entry
            {
                Placeholder = "e.g. Doe",

            }, 1, 5);

            grid.Children.Add(new Label
            {

                Text = "Phone Number",
                FontSize = 20,
                TextColor = Color.White

            }, 1, 6);

            grid.Children.Add(new Entry
            {
                Placeholder = "e.g. 312-123-4567",

            }, 1, 7);

            grid.Children.Add(new Label
            {

                Text = "Email",
                FontSize = 20,
                TextColor = Color.White

            }, 1, 8);

            grid.Children.Add(new Entry
            {
                Placeholder = "e.g. example@mail.com",

            }, 1, 9);

            grid.Children.Add(new Label
            {

                Text = "Address",
                FontSize = 20,
                TextColor = Color.White

            }, 1, 10);

            grid.Children.Add(new Entry
            {
                Placeholder = "e.g. 1234 Example St.",

            }, 1, 11);

            grid.Children.Add(new Button
            {
                Text = "Save",
                TextColor = Color.White,
                TextTransform = TextTransform.Uppercase,
                BackgroundColor = Color.Blue,

            }, 1, 12);

            this.Content = grid;
        }
    }
}
