using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLab5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPage3 : ContentPage
    {
        public NavigationPage3(string product, string quantity, string date, string time)
        {
            InitializeComponent();

            double price = 0;

            if (product == "Computer")
            {
                price = 500.00;
            }
            else if (product == "Camera")
            {
                price = 30.00;
            }
            else if (product == "Furniture")
            {
                price = 200.00;
            }
            else if (product == "Utensils")
            {
                price = 10.00;
            }
            else if (product == "Shirts")
            {
                price = 20.00;
            }
            else if (product == "Shoes")
            {
                price = 150.00;
            }
            else if (product == "Tools")
            {
                price = 30.00;
            }
            else if (product == "Cosmetics")
            {
                price = 30.00;
            }
            else if (product == "Food")
            {
                price = 200.00;
            }
            else if (product == "Pets")
            {
                price = 100.00;
            }
            else if (product == "Toys")
            {
                price = 75.00;
            }
            else if (product == "Chandelier")
            {
                price = 300.00;
            }


            Title = "Invoice";

            ToolbarItems.Clear();
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Home Page",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() =>
                Navigation.PushAsync(new MainPage()))
            });
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Company Info",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() =>
                Navigation.PushAsync(new NavigationPage2(product, quantity, date, time)))
            });

            Label noData = new Label()
            {
                Text = "No Transaction has been made yet.",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                IsVisible = true
            };

            Label transactionDetLabel = new Label()
            {
                Text = "Transaction Details",
                FontSize = 34,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Label productLabel = new Label()
            {
                Text = "Product selected: " + product,
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Label quantityLabel = new Label()
            {
                Text = "Quantity: " + quantity,
                FontSize = 24,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Label dateLabel = new Label()
            {
                Text = "Delivery Date: " + date,
                FontSize = 24,
                HorizontalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Label timeLabel = new Label()
            {
                Text = "Selected delivery time (actual): " + time,
                FontSize = 24,
                HorizontalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Label priceLabel = new Label()
            {
                Text = "Price: $" + price,
                FontSize = 24,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            
            if (productLabel.Text != null)
            {
                noData.IsVisible = false;
            }


            StackLayout transactionInfo = new StackLayout()
            {
                Children =
                {
                    transactionDetLabel, noData, productLabel, quantityLabel, dateLabel, timeLabel, priceLabel
                }
            };
            this.Content = transactionInfo;
        }
    }
}