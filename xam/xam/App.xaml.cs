using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xam.Services;
using xam.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;


namespace xam
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("1819574d-f2c6-4135-9a1d-f80cd118b87a", typeof(Push));
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
