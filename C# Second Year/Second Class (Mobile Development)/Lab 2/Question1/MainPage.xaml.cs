using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Lab2_Q1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            RelativeLayout relativeLayout = new RelativeLayout();

            BackgroundColor = Color.Orange;

            Label regLabel = new Label
            {
                Text = "Register",
                FontSize = 32,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center
            };

            relativeLayout.Children.Add(regLabel,
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width * 0.35;
            }), //Width
            //Constraint.Constant(150), //X-Axis Position
            Constraint.Constant(0)); //Y-Axis Position

            Label fnLabel = new Label
            {
                Text = "First Name",
                FontSize = 20,
                TextColor = Color.White
            };

            relativeLayout.Children.Add(fnLabel,
            Constraint.Constant(0), //X-Axis Position
            Constraint.Constant(200)); //Y-Axis Position

            Entry fnEntry = new Entry
            {
                Placeholder = "e.g. John",
            };

            relativeLayout.Children.Add(fnEntry,
            Constraint.Constant(0), //X-Axis Position
            Constraint.Constant(220), //Y-Axis Position
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width / 1;
            })); //Width

            Label lnLabel = new Label
            {
                Text = "Last Name",
                FontSize = 20,
                TextColor = Color.White
            };

            relativeLayout.Children.Add(lnLabel,
            Constraint.Constant(0),
            Constraint.Constant(280));

            Entry lnEntry = new Entry
            {
                Placeholder = "e.g. Doe",
            };

            relativeLayout.Children.Add(lnEntry,
            Constraint.Constant(0),
            Constraint.Constant(300),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width / 1;
            }));


            Label phoneLabel = new Label
            {
                Text = "Phone Number",
                FontSize = 20,
                TextColor = Color.White
            };

            relativeLayout.Children.Add(phoneLabel,
            Constraint.Constant(0),
            Constraint.Constant(360));

            Entry phoneEntry = new Entry
            {
                Placeholder = "e.g. 312-123-4567",
            };

            relativeLayout.Children.Add(phoneEntry,
            Constraint.Constant(0),
            Constraint.Constant(380),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width / 1;
            }));

            Label emailLabel = new Label
            {
                Text = "Email",
                FontSize = 20,
                TextColor = Color.White
            };

            relativeLayout.Children.Add(emailLabel,
            Constraint.Constant(0),
            Constraint.Constant(440));

            Entry emailEntry = new Entry
            {
                Placeholder = "e.g. example@mail.com",
            };

            relativeLayout.Children.Add(emailEntry,
            Constraint.Constant(0),
            Constraint.Constant(460),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width / 1;
            }));

            Label addressLabel = new Label
            {
                Text = "Address",
                FontSize = 20,
                TextColor = Color.White
            };

            relativeLayout.Children.Add(addressLabel,
            Constraint.Constant(0),
            Constraint.Constant(520));

            Entry addressEntry = new Entry
            {
                Placeholder = "1234 Example St.",
            };

            relativeLayout.Children.Add(addressEntry,
            Constraint.Constant(0),
            Constraint.Constant(540),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width / 1;
            }));

            Button saveButton = new Button
            {
                Text = "Save",
                TextColor = Color.White,
                TextTransform = TextTransform.Uppercase,
                BackgroundColor = Color.Blue,
            };

            relativeLayout.Children.Add(saveButton,
                Constraint.Constant(0),
                Constraint.Constant(600),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width / 1;
                }));


            Content = relativeLayout;
        }
    
    }
}
