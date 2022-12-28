using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLab6P1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            //MainPage = new ListObservablePage();

            MainPage = new NavigationPage(new ListObservablePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
