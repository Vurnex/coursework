using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Lab4
{
    public partial class MainPage : ContentPage
    {

        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }

        public class HeaderCell : ViewCell
        {
            public HeaderCell()
            {
                this.Height = 50;
                var title = new Label
                {
                    FontSize = 30,
                    TextColor = Color.Black,
                    FontAttributes = FontAttributes.Bold,
                    VerticalOptions = LayoutOptions.Center
                };
                title.SetBinding(Label.TextProperty, "Key");
                View = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    HeightRequest = 40,
                    BackgroundColor = Color.DarkGray,
                    Padding = 5,
                    Orientation = StackOrientation.Horizontal,
                    Children = { title }
                };
            }
        }

        public MainPage()
        {
            InitializeComponent();

            List<Group> itemsGrouped = new List<Group>
                {
                    new Group("Tech", new List<ListItem>
                    {
                        new ListItem {Title = "Computer", Description="1st item", Price="$500.00"},
                        new ListItem {Title = "Camera", Description="2nd item", Price="$30.00"},


                    }),
                    new Group("House", new List<ListItem>
                    {
                        new ListItem {Title = "Funiture", Description="1st item", Price="$200.00"},
                        new ListItem {Title = "Utensils", Description="2nd item", Price="$10.00"},

                    }),

                    new Group("Clothing", new List<ListItem>
                    {
                        new ListItem {Title = "Shirts", Description="1st item", Price="$20.00"},
                        new ListItem {Title = "Shoes", Description="2nd item", Price="$150.00"},

                    }),
                    new Group("Others", new List<ListItem>
                    {
                        new ListItem {Title = "Tools", Description="1st item", Price="$30.00"},
                        new ListItem {Title = "Cosmetics", Description="2nd item", Price="$30.00"},
                        new ListItem {Title = "Food", Description="3rd item", Price="$200.00"},
                        new ListItem {Title = "Pets", Description="4th item", Price="$100.00"},
                        new ListItem {Title = "Toys", Description="5th item", Price="$75.00"},
                        new ListItem {Title = "Chandelier", Description="6th item", Price="$300.00"}

                    }),
                };


            ListView listView = new ListView()
            {
                IsGroupingEnabled = true,
                GroupDisplayBinding = new Binding("Key"),
                GroupHeaderTemplate = new DataTemplate(typeof(HeaderCell)),
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(typeof(TextCell))
                {
                    Bindings = {
                            { TextCell.TextProperty, new Binding("Title") },
                            { TextCell.DetailProperty, new Binding("Description") }
                    }
                }
            };

            listView.ItemsSource = itemsGrouped;

            listView.RowHeight = 100;
            listView.HasUnevenRows = true;
            listView.ItemTemplate = new DataTemplate(typeof(ListItemCell));

            Label eventValue = new Label
            {
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
            };


            DatePicker datePicker1 = new DatePicker
            {
                TextColor = Color.Blue,
                Format = "d",
                VerticalOptions = LayoutOptions.Center
            };

            datePicker1.DateSelected += (object sender, DateChangedEventArgs e) =>
            {
                
            };

            TimePicker timePicker1 = new TimePicker
            {
                Format = "T",
                VerticalOptions = LayoutOptions.Center
            };

            timePicker1.PropertyChanged += (sender, e) =>
            {
                
            };

            Label selectedPayment = new Label();

            Picker paymentMethod = new Picker
            {
                Title = "Choose a payment method",
                VerticalOptions = LayoutOptions.Center
            };
            paymentMethod.Items.Add("Credit / Debit ");
            paymentMethod.Items.Add("Paypal");
            paymentMethod.Items.Add("Apple Pay");
            paymentMethod.Items.Add("Google Pay");
            paymentMethod.Items.Add("Digital Wallet");

            paymentMethod.SelectedIndexChanged += (sender, args) =>
            {
               selectedPayment.Text = paymentMethod.Items[paymentMethod.SelectedIndex];
            };

            Button submit = new Button
            {
                Text = "Submit",
                HorizontalOptions = LayoutOptions.Center
            };

            submit.Clicked += (sender, args) =>
            {

                if (stepper.Value.Equals(null) || stepper.Value.Equals(0) )
                {
                    DisplayAlert("Alert", "Please pick an amount of the product.", "OK");
                }

                else if (selectedPayment.Text == null)
                {
                    DisplayAlert("Alert", "Please pick a payment method.", "OK");
                }    
                else
                {
                    DisplayAlert("Alert", "Processing payment...", "OK");
                }

            };


            StackLayout dataView = new StackLayout
            {
                Padding = 5,
                Children = { 
                    stepper, 
                    eventValue, 
                    datePicker1,
                    timePicker1,
                    paymentMethod,
                    submit
                },
            };

            StackLayout contentLayout = new StackLayout()
            {
                Children = { listView, dataView }
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Content = contentLayout
            };

            this.Content = scrollView;

            //Content = contentLayout;

            listView.ItemTapped += async (sender, e) =>
            {
                ListItem item = (ListItem)e.Item;
                await DisplayAlert("Tapped", item.Title.ToString() + "  was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
        }

        public class Group : List<ListItem>
        {
            public string Key
            {
                get;
                private set;
            }
            public Group(string key, List<ListItem> listItems)
            {
                
                Key = key;
                foreach (var item in listItems)
                    this.Add(item);
            }

            
        }

        public class ListViewGroupedViewModel : BindableObject
        {
            List<Group> itemsGrouped;
            public List<Group> ItemsGrouped
            {
                get
                {
                    return itemsGrouped;
                }
                set
                {
                    itemsGrouped = value;
                    OnPropertyChanged("ItemsGrouped");
                }
            }
        }

        class ListItemCell : ViewCell
        {
            public ListItemCell()
            {

                Label titleLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.Start,
                    FontSize = 25,
                    FontAttributes = Xamarin.Forms.FontAttributes.Bold,
                    TextColor = Color.Black
                };

                titleLabel.SetBinding(Label.TextProperty, "Title");

                Label descLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.Start,
                    FontSize = 20,
                    TextColor = Color.Black
                };

                descLabel.SetBinding(Label.TextProperty, "Description");

                StackLayout viewLayoutItem = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.Start,
                    Orientation = StackOrientation.Vertical,
                    WidthRequest = 120,
                    Children = { titleLabel, descLabel }
                };

                Label priceLabel = new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    FontSize = 25,
                    TextColor = Color.Black
                };

                priceLabel.SetBinding(Label.TextProperty, "Price");

                var button = new Button //ListButton // Android workaround
                {
                    Text = "Buy Now",
                    TextColor = Color.White,
                    BackgroundColor = Color.Teal,
                    HorizontalOptions = LayoutOptions.EndAndExpand
                };

                button.SetBinding(Button.CommandParameterProperty, new Binding("."));
                
                button.Clicked += (sender, e) =>
                {
                    var b = (Button)sender;
                    var item = (ListItem)b.CommandParameter;

                    ((ContentPage)
                    ((ScrollView)
                    ((StackLayout)
                    ((ListView)
                    ((StackLayout)
                    ((StackLayout)
                    b.ParentView).ParentView).ParentView).ParentView).ParentView).ParentView).DisplayAlert("Clicked", item.Title.ToString() 
                    + "was selected. Processing payment...", "OK");
                };

                StackLayout viewButton = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.EndAndExpand,
                    Orientation = StackOrientation.Horizontal,
                    WidthRequest = 260,
                    Children = { priceLabel, button }
                };


                StackLayout viewLayout = new StackLayout()
                {
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    Orientation = StackOrientation.Horizontal,
                    Padding = new Thickness(5, 10, 5, 15),
                    Children = { viewLayoutItem, viewButton }
                };

                View = viewLayout;

            }

        }

    }
}
