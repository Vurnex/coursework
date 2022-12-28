using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;  // Needed for observable collection.

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLab6P2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListObservablePage : ContentPage
    {
        public ListObservablePage()
        {
            InitializeComponent();

            Title = "List Binding";

            ListView listView = new ListView();

            var items = new List<ObservableItem> {
                 new ObservableItem {Title = "First", Description="1st item"},
                 new ObservableItem {Title = "Second", Description="2nd item"},
                 new ObservableItem {Title = "Third", Description="3rd item"}
            };

            listView.ItemsSource = items;
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listView.ItemTemplate.SetBinding(TextCell.DetailProperty, "Description");

            listView.ItemTapped += async (sender, e) =>
            {
                Item item = (Item)e.Item;
                await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            Button buttonEdit = new Button
            {
                Text = "Edit Row",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            buttonEdit.Clicked += async (sender, args) =>
            {
                if (items.Count == 0)
                {
                    await DisplayAlert("No Items", "There are no items in the list to edit.", "OK");
                }
                else
                {
                    items[0].Title = "First Edited";
                    await DisplayAlert("Item Object", "Title changed", "OK");
                }

            };

            Content = new StackLayout
            {
                Children = { buttonEdit, listView }
            };

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
        }
    }
}