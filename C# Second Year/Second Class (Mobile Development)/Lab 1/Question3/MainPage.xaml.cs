using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Lab1_Q3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Image bannerImg = new Image {

                Source = ImageSource.FromResource("App-Lab1-Q3.Images.banner.jpg"),
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,

            };

            BackgroundColor = Color.SandyBrown;

            Label regLabel = new Label { 
                Text = "Register", 
                TextColor = Color.White,
                TextTransform = TextTransform.Uppercase, 
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic, 
                FontSize = 32,
                HorizontalOptions = LayoutOptions.Center
            };

            Label fnLabel = new Label { Text = "First Name", TextColor = Color.White };


            Entry fnEntry = new Entry
            {
                Placeholder = "e.g. John",

            };


            Label lnLabel = new Label { Text = "Last Name", TextColor = Color.White };

            Entry lnEntry = new Entry
            {
                Placeholder = "e.g. Doe",

            };

            Label numLabel = new Label { Text = "Phone Number", TextColor = Color.White };

            Entry numEntry = new Entry
            {
                Placeholder = "e.g. 312-555-9099",

            };

            Label emLabel = new Label { Text = "Email", TextColor = Color.White };

            Entry emEntry = new Entry
            {
                Placeholder = "example@gmail.com",

            };

            Label adrsLabel = new Label { Text = "Address", TextColor = Color.White };

            Entry adrsEntry = new Entry
            {
                Placeholder = "1710 Main St.",

            };

            Button saveButton = new Button
            {
                Text = "Save", TextColor = Color.White, BackgroundColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Fill
            };

            saveButton.Clicked += (sender, args) =>
            {
                DisplayAlert("Saved", "Data has been saved!", "OK");

                var child = this.Content as Layout;
                if (child != null)
                {
                    ProcessLayoutChildren(child);
                }

            };

            
            StackLayout stack1 = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,

                Children =
                {
                    bannerImg, regLabel, fnLabel, fnEntry, lnLabel, lnEntry, numLabel, numEntry,
                    emLabel, emEntry, adrsLabel, adrsEntry, saveButton
                }
            };

            this.Content = stack1;

        }

        public void ProcessLayoutChildren(Layout child)
        {
            foreach (var item in child.Children)
            {
                var layout = item as Layout;
                if (layout != null)
                {
                    ProcessLayoutChildren(layout);
                }
                else
                {
                    ClearEntry(item);
                }
            }

            void ClearEntry(Element entryElement)
            {
                var entry = entryElement as Entry;
                if (entry != null)
                {
                    entry.Text = string.Empty;
                }
            }
        }
    }
}
