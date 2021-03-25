using DatingApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views.HomePages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopPicksPage : ContentPage
    {
        ObservableCollection<Person> listOfPersons = new ObservableCollection<Person>();

        public TopPicksPage()
        {
            InitializeComponent();
            AddedPersonDate();
            lstOfTopPickers.ItemsSource = listOfPersons;
        }
        private void AddedPersonDate()
        {
            listOfPersons.Add(new Person { Name = "Vani", Age = "21", Active = true, PersonImae = "person1.jpg" });
            listOfPersons.Add(new Person { Name = "sri", Age = "19", Active = false, PersonImae = "person2.jpg" });
            listOfPersons.Add(new Person { Name = "Ram", Age = "25", Active = true, PersonImae = "person3.jpg" });
        }
    }
}