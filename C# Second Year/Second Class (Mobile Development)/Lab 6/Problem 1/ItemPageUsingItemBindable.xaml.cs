using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLab6P1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemPageUsingItemBindable : ContentPage
    {
        public ItemPageUsingItemBindable()
        {
            InitializeComponent();
            var itemBindable = new ItemBindable();
            itemBindable.Title = "First";
            this.BindingContext = itemBindable;

            var titleEntry = new Entry()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            titleEntry.SetBinding(Entry.TextProperty, new Binding("Title"));

            Button buttonDisplay = new Button
            {
                Text = "Display Item Value",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            buttonDisplay.Clicked += async (sender, args) =>
            {
                await DisplayAlert("Item Object", "Title property:" + itemBindable.Title.ToString(), "OK");
            };

            Button buttonUpdate = new Button
            {
                Text = "Update the Data Model",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            buttonUpdate.Clicked += async (sender, args) =>
            {
                itemBindable.Title = "Updating the data model!";
                await DisplayAlert("Item Object", "Title property:" + itemBindable.Title.ToString(), "OK");
            };


            Content = new StackLayout
            {
                Children = { titleEntry, buttonDisplay, buttonUpdate }
            };
        }
    }
}