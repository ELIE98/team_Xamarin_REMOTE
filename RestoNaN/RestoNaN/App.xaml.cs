using System;
using System.IO;
using System.Net.Http;
using DLToolkit.Forms.Controls;
using RestoNaN;
using RestoNaN.views;
using Xamarin.Forms;

namespace RestoNaN
{
    public partial class App : Application

    {


        static SqLiteHelper db;


        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new Started());
        }

        public static SqLiteHelper SQliteDb5
        {

            get
            {
                if (db == null)
                {
                    db = new SqLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "restauSQLite.db3"));
                }

                return db;
            }
        }



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
