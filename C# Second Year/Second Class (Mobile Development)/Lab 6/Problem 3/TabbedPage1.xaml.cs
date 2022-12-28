using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLab6P3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();

            this.Title = "Trip Information";

            this.Children.Add(new FirstPage() { Title = "Flight Expenses" });
            this.Children.Add(new SecondPage() { Title = "Car Rental" });
            this.Children.Add(new ThirdPage() { Title = "Hotel Expenses" });
            this.Children.Add(new FourthPage() { Title = "Meal Expenses" });
            this.Children.Add(new FifthPage() { Title = "Other Expenses" });

            //remove predefined tabs
            this.Children.RemoveAt(0);
            this.Children.RemoveAt(0);
            this.Children.RemoveAt(0);

            //this.CurrentPage = this.Children[1];
        }
    }
}