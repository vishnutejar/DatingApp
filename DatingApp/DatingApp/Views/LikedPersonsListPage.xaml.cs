using DatingApp.Models;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LikedPersonsListPage : ContentPage
    {
        ObservableCollection<Person> listOfPersons = new System.Collections.ObjectModel.ObservableCollection<Person>();
        public LikedPersonsListPage()
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
        }
    }
}