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
    public partial class NavigationPage2 : ContentPage
    {
        public NavigationPage2(string product, string quantity, string date, string time)
        {
            InitializeComponent();
            

            Title = "Company Information";

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
                Text = "Invoice",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() =>
                Navigation.PushAsync(new NavigationPage3(product, quantity, date, time)))
            });

            Label homeLabel = new Label
            {
                Text = "Company Info",
                FontSize = 40,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Label companyName = new Label
            {
                Text = "App Store Solutions",
                FontSize = 32,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontAttributes = FontAttributes.Bold

            };

            Label companyDescription = new Label
            {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                FontSize = 18,
                HorizontalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Button thirdPage = new Button()
            {
                Text = "Navigate to Third Page",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            thirdPage.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new NavigationPage3(product, quantity, date, time));

            StackLayout stackLayout = new StackLayout
            {
                Children = { homeLabel, companyName, companyDescription, thirdPage }
            };
            this.Content = stackLayout;
        }
    }
}