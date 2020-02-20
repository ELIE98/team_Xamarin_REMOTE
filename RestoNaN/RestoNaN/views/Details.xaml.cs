using System;
using System.Collections.Generic;
using RestoNaN.models;
using Xamarin.Forms;

namespace RestoNaN.views
{
    public partial class Details : ContentPage
    {
        public Details()
        {
            InitializeComponent();

            // GoBack.Clicked += GoBack_Clicked;
            CartButton.Clicked += CartButton_Clicked;
            GoBack.Clicked += GoBack_Clicked;

        }

        async private void GoBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async private void CartButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cart());
        }

        //async private void GoBack_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Food());
        //}
    }
}
