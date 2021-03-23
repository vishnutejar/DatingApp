using DatingApp.Models;
using DatingApp.Resx;
using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassionsPage : ContentPage
    {
        int PassionLimitted = 5;
        ObservableCollection<PassionItems> PassionItems { get; set; } = new ObservableCollection<PassionItems>();
        public PassionsPage()
        {
            InitializeComponent();
            PassionItems = new ObservableCollection<PassionItems>();
            PassionItems.Add(new Models.PassionItems() { PassionName = "Spirituality" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Golf" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Netflix" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Museum" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Tea" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Vlogging" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Potterhead" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "K-Pop" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Wine" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Festivals" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Slam Petry" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Cat Lover" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Musician" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Hiking" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Cricket" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Road Trips" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Movies" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Shopping" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Maggi" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Sneakers" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Cooking" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Grab a drink" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Stand Up Comedy" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Writer" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Dog lover" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Art" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Banking" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Instagram" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Bhangra" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Vegetarian" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Ludo" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Coffee" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Running" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Bollywood" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Karaoke" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Gardening" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "DIY" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Fashion" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Athlete" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Volunteering" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Poetry" });
            PassionItems.Add(new Models.PassionItems() { PassionName = "Dancing" });
            lstPassionName.ItemsSource = PassionItems;
        }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void GotoAddPhotosPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPhotosPage());
        }

        private void SelectedPassionNames(object sender, SelectionChangedEventArgs e)
        {
            var current = e.CurrentSelection;
            var selectedItemCount = current.Count;

            for (int i = 0; i < current.Count; i++)
            {

                if (PassionLimitted >= selectedItemCount)
                {
                    var data = current[i] as PassionItems;
                    countContinueButton.Text = AppResource.Continue + " " + AppResource.Count + " " + "( " + selectedItemCount + " / " + PassionLimitted + ")";

                }
                else
                {
                    DisplayAlert("", "only 5 passion we can select", "ok");
                    ((CollectionView)sender).SelectedItem = null;

                }
            }
        }
    }
}