using System;
using Xamarin.Forms;

namespace RestoNaN.models
{
    public class Restaurant
    {
        public int id { get; set; }
        public string city { get; set; }
        public string image { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public string image3 { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string street { get; set; }
        public string description { get; set; }
        public DateTime date_add { get; set; }
        public DateTime date_upd { get; set; }
        public bool status { get; set; }
        public int categorie_restaurant { get; set; }

    }
}
