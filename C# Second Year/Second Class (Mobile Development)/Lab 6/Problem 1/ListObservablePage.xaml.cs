using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;  // Needed for observable collection.

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLab6P1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListObservablePage : ContentPage
    {
        public ListObservablePage()
        {
            InitializeComponent();

            Title = "List Binding";

            ListView listView = new ListView();

            var items = new ObservableCollection<Item> {
                new Item {Title = "First", Description="1st item"},
                new Item {Title = "Second", Description="2nd item"},
                new Item {Title = "Third", Description="3rd item"},
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

            Button buttonAdd = new Button
            {
                Text = "Add Row",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            buttonAdd.Clicked += async (sender, args) =>
            {
                items.Add(new Item { Title = "New Item", Description = "new item" });
                await DisplayAlert("Item Object", "Item Added", "OK");

            };

            Button buttonDelete = new Button
            {
                Text = "Delete Row ",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            buttonDelete.Clicked += async (sender, args) =>
            {
                if (items.Count == 0)
                {
                    await DisplayAlert("No Items", "There are no items in the list to delete.", "OK");
                }
                else
                {
                    items.RemoveAt(0);
                    await DisplayAlert("Item Object", "Row deleted", "OK");
                }

            };

            Content = new StackLayout
            {
                Children = { buttonAdd, buttonDelete, listView }
            };

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
        }
    }
}