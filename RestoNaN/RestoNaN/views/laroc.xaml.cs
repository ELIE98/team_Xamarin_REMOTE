using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RestoNaN.views
{
    public partial class laroc : ContentPage
    {
        public laroc()
        {
            InitializeComponent();
            signup.Clicked += signup_Clicked;

        }
        async private void signup_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text))
            {

                await DisplayAlert("Requiered", "Verifié que vous avez saiisir le email", "ok");

            }

            else if (string.IsNullOrEmpty(password.Text))
            {

                await DisplayAlert("Requiered", "Verifié que vous avez saiisir le phone", "ok");

            }
            else
            {
                var person = await App.SQliteDb5.connexion(email.Text, password.Text);

                if (person == null)
                {
                    await DisplayAlert("Requiered", "Email ou Mot de passe incorrect", "ok");
                }

                else
                {
                    await Navigation.PushAsync(new Started());
                }
            }
        }
    }
}




