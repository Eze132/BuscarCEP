using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppCEP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NuGetPag(); //MainPage();
            // MainPage = new MenuPage();
            MainPage = new NavigationPage( new TLogin());
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
