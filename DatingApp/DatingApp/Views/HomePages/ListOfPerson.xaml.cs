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
    public partial class ListOfPerson : ContentPage
    {
        public ListOfPerson()
        {
            InitializeComponent();
            ObservableCollection<string> lstOfPersonImages = new ObservableCollection<string>
            {
                "person1.jpg",//new Student(){Name="",Marks="70"}
                "person2.jpg",
                "person3.jpg",
                "person4.jpg",
                "person5.jpg",
                "person4.jpg",
                "person2.jpg"
            };
            personsimages.ItemsSource = lstOfPersonImages;
        }
    }
}