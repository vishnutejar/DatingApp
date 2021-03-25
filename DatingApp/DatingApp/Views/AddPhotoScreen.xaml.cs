using Plugin.Media;
using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPhotoScreen : ContentPage
    {
        public AddPhotoScreen()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, EventArgs e)
        {

        }

        private void GoToHomeScreen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomeTabbedPage());
        }

        private void PickImageOne(object sender, EventArgs e)
        {
            //code for picking the image from camera or gallery 
            
        }

        private void PickImageTwo(object sender, EventArgs e)
        {
            //code for picking the image from camera or gallery 

        }

        async Task<ImageSource> GetMeidaFile()
        {

            await CrossMedia.Current.Initialize();
            var selectedImageFile = await CrossMedia.Current.PickPhotoAsync();
            var selctedimage = ImageSource.FromStream(() => selectedImageFile.GetStream());
            return selctedimage;
        }

        private void Pickimage(object sender, EventArgs e)
        {
            selectedimage.Source= GetMeidaFile().Result;
        }
    }
}