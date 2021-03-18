using DatingApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new AppIntro());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
