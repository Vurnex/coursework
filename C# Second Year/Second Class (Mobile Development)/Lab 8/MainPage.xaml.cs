using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppLab8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnSaveButtonClicked(object sender, EventArgs args)
        {
            DisplayAlert("Saved", "Data has been saved!", "OK");
            firstNameEntry.Text = "";
            lastNameEntry.Text = "";
            phoneNumEntry.Text = "";
            emailEntry.Text = "";
            addressEntry.Text = "";
        }
    }
}
