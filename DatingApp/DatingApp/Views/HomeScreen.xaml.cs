using DatingApp.Models;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeScreen : ContentPage
    {
        ObservableCollection<Person> listOfPersons = new System.Collections.ObjectModel.ObservableCollection<Person>();
        public HomeScreen()
        {
            InitializeComponent();
            AddedPersonDate();
            lstviewPersons.ItemsSource = listOfPersons;
        }

        private void AddedPersonDate()
        {
            listOfPersons.Add(new Person { Name = "Vani", Age = "21", Active = true });
            listOfPersons.Add(new Person { Name = "sri", Age = "19", Active = false });
            listOfPersons.Add(new Person { Name = "Ram", Age = "25", Active = true});
            listOfPersons.Add(new Person { Name = "Ram Theja", Age = "25", Active = true});
            listOfPersons.Add(new Person { Name = "Priyank jain", Age = "25", Active = true});
        }
    }
}