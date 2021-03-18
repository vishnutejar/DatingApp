using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppIntro : ContentPage
    {
        public AppIntro()
        {
            InitializeComponent();
        }

        private void GotoHomeScreen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}