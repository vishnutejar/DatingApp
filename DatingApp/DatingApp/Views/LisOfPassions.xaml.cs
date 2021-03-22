using DatingApp.Models;
using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LisOfPassions : ContentPage
    {
        ObservableCollection<PassionsItems> PassionItems { get; set; } = new ObservableCollection<PassionsItems>();
        public LisOfPassions()
        {
            InitializeComponent();
            PassionItems = new ObservableCollection<PassionsItems>();
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Spirituality" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Golf" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Netflix" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Museum" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Tea" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Vlogging" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Potterhead" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "K-Pop" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Wine" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Festivals" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Slam Petry" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Cat Lover" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Musician" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Hiking" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Cricket" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Road Trips" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Movies" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Shopping" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Maggi" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Sneakers" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Cooking" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Grab a drink" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Stand Up Comedy" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Writer" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Dog lover" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Art" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Banking" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Instagram" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Bhangra" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Vegetarian" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Ludo" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Coffee" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Running" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Bollywood" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Karaoke" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Gardening" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "DIY" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Fashion" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Athlete" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Volunteering" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Poetry" });
            PassionItems.Add(new Models.PassionsItems() { PassionName = "Dancing" });
            lstOfPassions.ItemsSource = PassionItems;
        }

        private void GoToAddPhotosPage(object sender, EventArgs e)
        {

        }

        private void lstOfPassions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var itemsSelected = e.CurrentSelection;
            var mySelectionCount = itemsSelected.Count;
            continueCount.Text = "Continue " + "(" + mySelectionCount + "/" + "5" + ")";

        }
    }
}