using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPhotosPage : ContentPage
    {
        string PhotoPath;
        public AddPhotosPage()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        async Task TakePhotoAsync()
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                await LoadPhotoAsync(photo);
                Console.WriteLine($"CapturePhotoAsync COMPLETED: {PhotoPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
            }
        }
        async Task SelectPhotoAsync()
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
                await LoadPhotoAsync(photo);
                Console.WriteLine($"CapturePhotoAsync COMPLETED: {PhotoPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
            }
        }

        async Task LoadPhotoAsync(FileResult photo)
        {
            // canceled
            if (photo == null)
            {
                PhotoPath = null;
                return;
            }
            // save the file into local storage
            var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
            using (var stream = await photo.OpenReadAsync())
            using (var newStream = File.OpenWrite(newFile))
                await stream.CopyToAsync(newStream);

            PhotoPath = newFile;
            selectedimage1.Source = PhotoPath;
            selectedimage2.Source = PhotoPath;
            selectedimage3.Source = PhotoPath;
            selectedimage4.Source = PhotoPath;
            selectedimage5.Source = PhotoPath;
            selectedimage6.Source = PhotoPath;
        }
        async void SelectImageFromGallery(object sender, EventArgs e)
        {
           await SelectPhotoAsync();
        }

        async void PhotoCaptureFromCamera(object sender, EventArgs e)
        {
           await TakePhotoAsync();
        }

        private void GoToHomeScreen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomeTabbedPage());
        }
    }
}