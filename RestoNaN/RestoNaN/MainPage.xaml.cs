using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestoNaN.models;
using RestoNaN.views;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace RestoNaN
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Restaurant listresto = new Restaurant();


        public MainPage()
        {

            InitializeComponent();

            LoadResto();



        }






        public async void LoadResto()
        {
            var conn = Connectivity.NetworkAccess;
            try
            {
                if (conn == NetworkAccess.Internet)
                {
                    var url = "http://192.168.50.93:8001/Restaurant/";

                    HttpClient client = new HttpClient();
                    var content = client.GetStringAsync(url).Result;
                    var contentDeserialise = JsonConvert.DeserializeObject<List<Restaurant>>(content);
                    ListeResto.ItemsSource = contentDeserialise;

                    ListeCategorieResto.ItemSelected += ListeCategorieResto_ItemSelected;

                    ListeResto.ItemSelected += ListeResto_ItemSelected;


                }
                //await DisplayAlert("Connection", "Please check your network", "ok");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            LoadCategorieResto();
        }

        //fonction ramenant la liste des restaurants en fonction de la categorie

        private void ListeCategorieResto_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var categorieSelect = (CategorieRestaurant)e.SelectedItem;

            var IdcategorieSelect = categorieSelect.id;

            var url = "http://192.168.50.93:8001/Restaurant/";

            HttpClient client = new HttpClient();
            var content = client.GetStringAsync(url).Result;
            var contentDeserialise = JsonConvert.DeserializeObject<List<Restaurant>>(content);

            var RestoSortedByCategorie = contentDeserialise.Where(c => c.categorie_restaurant == IdcategorieSelect);


            ListeResto.ItemsSource = RestoSortedByCategorie;

        }

        // Fonction pour retourner les categories de restaurant

        public async void LoadCategorieResto()
        {
            var url = "http://192.168.50.93:8001/Categorierestaurant/";
            HttpClient client = new HttpClient();
            var content = client.GetStringAsync(url).Result;
            var contentDeserialise = JsonConvert.DeserializeObject<List<CategorieRestaurant>>(content);

            ListeCategorieResto.ItemsSource = contentDeserialise;



        }

        async private void ListeResto_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var restoSelectionne = (Restaurant)e.SelectedItem;


            // j ai fait passer les different champs de l objet selectionné plutot que de faire passer son ID à la vue FOOD()
            // modification de la couleur par defaut d un item Selectionne dans Android/Ressource/Values/styles.xml/ 
            //    < item name = "android:colorActivatedHighlight" > @android:color / transparent </ item >


            await Navigation.PushAsync(new Food(restoSelectionne.name, restoSelectionne.city, restoSelectionne.description, restoSelectionne.image, restoSelectionne.image1, restoSelectionne.image2, restoSelectionne.image3));
            restoSelectionne = null;


        }




    }
}

