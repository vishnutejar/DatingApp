using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            imgLogo.Opacity = 0;
            await Task.WhenAny<bool>
            (
            imgLogo.FadeTo(1, 2000)
            );
            await Task.WhenAny<bool>
            (
            imgLogo.TranslateTo(-DeviceDisplay.MainDisplayInfo.Width, 0, 500)
            );
            App.Current.MainPage = new NavigationPage(new AppIntro());
        }
    }
}