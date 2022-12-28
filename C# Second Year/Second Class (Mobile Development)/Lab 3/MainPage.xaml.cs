using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Lab3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            string product = "";
            string qty = "";

            Label label1 = new Label
            {
                Text = "App Store",
                FontSize = 32,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            Label eventValue = new Label
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            Label pageValue = new Label
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Label productLabel = new Label
            {
                Text = "Choose a product",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Picker picker = new Picker
            {
                Title = "Option",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var options = new List<string> { "Computers", "Furniture", "Cameras", "Clothing", "Utensils", 
            "Shoes", "Tools", "Cosmetics", "Food", "Pets"};
            foreach (string optionName in options)
            {
                picker.Items.Add(optionName);
            }

            // --------- Handle inline or setup Handler Method ----------
            picker.SelectedIndexChanged += (sender, args) =>
            {
                product = picker.Items[picker.SelectedIndex];
            };

            Label quantityLabel = new Label
            {
                Text = "Quantity: ",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Stepper stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 10,
                Increment = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            stepper.ValueChanged += (sender, e) =>
            {
                eventValue.Text = String.Format("Number of desired product is {0:F1}", e.NewValue);
                qty = stepper.Value.ToString();
            };

            Label dateLabel = new Label
            {
                Text = "Choose a day to deliver the product",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            DatePicker datePicker = new DatePicker
            {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            datePicker.DateSelected += (object sender, DateChangedEventArgs e) =>
            {
                //pageValue.Text = datePicker.Date.ToString();
            };

            Label timeLabel = new Label
            {
                Text = "Choose a preferred time for delivery",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            TimePicker timePicker = new TimePicker
            {
                Format = "T",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            timePicker.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
                {
                    //pageValue.Text = timePicker.Time.ToString();
                }
            };

            Label paymentLabel = new Label
            {
                Text = "Choose a payment method",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Picker picker2 = new Picker
            {
                Title = "Options",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var options2 = new List<string> { "Check", "Debit", "Credit", "App Pay", "Bank Transfer"};
            foreach (string optionName2 in options2)
            {
                picker2.Items.Add(optionName2);
            }

            Button saveButton = new Button
            {
                Text = "Submit",
                TextColor = Color.White,
                TextTransform = TextTransform.Uppercase,
                BackgroundColor = Color.Blue,
            };

            Label purchasedProduct = new Label()
            {
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 25,
                Text = "Purchased Product Description",
                IsVisible = false
            };

            saveButton.Clicked += (sender, args) =>
            {
                purchasedProduct.IsVisible = true;
                purchasedProduct.Text = "Product: " + product +
                    " Qty: " + qty;
            };


            StackLayout stack = new StackLayout
            {
                Children =
                {
                    label1, productLabel, picker, quantityLabel, eventValue, stepper, dateLabel, datePicker, timeLabel, timePicker,
                    paymentLabel, picker2, saveButton, purchasedProduct
                }
            };

            this.Content = stack;

        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new success());

            
        }
    }
}
