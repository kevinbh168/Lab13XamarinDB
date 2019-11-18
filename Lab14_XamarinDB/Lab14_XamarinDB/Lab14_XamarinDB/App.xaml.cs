using Lab14_XamarinDB.Repositories;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab14_XamarinDB
{
    public partial class App : Application
    {
        static TodoPersonaDatabase database;
        public App()
        {
            //InitializeComponent();

           // MainPage = new MainPage();

            Resources = new ResourceDictionary();
            Resources.Add("primaryGreen", Color.FromHex("91CA47"));
            Resources.Add("primaryDarkGreen", Color.FromHex("6FA22E"));

            var nav = new NavigationPage(new PersonaListPage());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            nav.BarTextColor = Color.White;

            MainPage = nav;

        }

        public static TodoPersonaDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoPersonaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PersonaSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }
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
