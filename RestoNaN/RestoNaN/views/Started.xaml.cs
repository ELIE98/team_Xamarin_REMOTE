using System;
using System.Collections.Generic;
using RestoNaN.views;
using Xamarin.Forms;

namespace RestoNaN
{
    public partial class Started : ContentPage
    {
        public Started()
        {
            InitializeComponent();

            List<ImageSource> image = new List<ImageSource>
                {
                ImageSource.FromFile("bg3.jpeg"),
                ImageSource.FromFile("macaronni.jpeg"),
                ImageSource.FromFile("lasanne.jpeg"),
            };

            Carousel.ItemsSource = image;

            Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() =>
            {
                Carousel.Position = (Carousel.Position + 1) % image.Count;
                return true;
            }));

            started.Clicked += Started_Clicked;


        }

        private void Started_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new article());
        }


    }
}
