using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Navigation.PushAsync(new HomeScreen());
        }
    }
}