using System;
using RestoNaN;
using SQLite;
using Xamarin.Forms;

namespace RestoNaN.views
{
    public partial class signUp : ContentPage
    {
        public signUp()
        {
            InitializeComponent();
            signup.Clicked += signup_Clicked;
        }
        async private void signup_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nom.Text))

            {

                await DisplayAlert("Required", "Verifiez que vous avez saiisir le nom", "ok");
            }

            else if (string.IsNullOrEmpty(prenom.Text))
            {

                await DisplayAlert("Required", "Verifiez que vous avez saiisir le prenom", "ok");

            }

            else if (string.IsNullOrEmpty(email.Text))
            {

                await DisplayAlert("Required", "Verifiez que vous avez saiisir le email", "ok");

            }

            else if (string.IsNullOrEmpty(phone.Text))
            {

                await DisplayAlert("Required", "Verifiez que vous avez saiisir le phone", "ok");

            }

            else if (string.IsNullOrEmpty(password.Text))
            {

                await DisplayAlert("Required", "Verifiez que vous avez saiisir le password", "ok");

            }

            else
            {

                Person person = new Person()
                {
                    nom = nom.Text,
                    prenom = prenom.Text,
                    email = email.Text,
                    phone = phone.Text,
                    password = password.Text

                };

                await App.SQliteDb5.inscription(person);
                await DisplayAlert("felicitation", "votre compte a été creé avec succes", "ok");
            }
        }
    }
}
