using System;
using RestoNaN.views;
using Xamarin.Forms;

namespace RestoNaN
{
    public partial class Food : ContentPage
    {
        // Recuperation des champs de l objet passe depuis le vue MainPage
        public Food(string Nom, string rue, string description, string imageprincipale, string i1, string i2, string i3)
        {

            InitializeComponent();


            BackButton.Clicked += BackButton_Clicked;
            nextButton.Clicked += nextButton_Clicked;
            // Binding par x:Name a la Uchenna plutot que Data Binding 
            NomResto.Text = Nom;
            DescriptionResto.Text = description;
            streetResto.Text = rue;
            imagePrincipale.Source = imageprincipale;
            im1.Source = i1;
            im2.Source = i2;
            im3.Source = i3;

        }
        async private void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        async private void nextButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Details());
        }
    }
}
