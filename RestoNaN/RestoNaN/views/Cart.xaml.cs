using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RestoNaN.views
{
    public partial class Cart : ContentPage
    {
        public Cart()
        {
            InitializeComponent();
            GoBackButton.Clicked += GoBackCart_Clicked;
        }
        async private void GoBackCart_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Details());
        }
    }
}
