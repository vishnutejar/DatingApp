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
            ObservableCollection<string> lstOfPersonImages = new ObservableCollection<string>();
            lstOfPersonImages.Add("person1.jpg");//new Student(){Name="",Marks="70"}
            lstOfPersonImages.Add("person2.jpg");
            lstOfPersonImages.Add("person3.jpg");
            lstOfPersonImages.Add("person4.jpg");
            lstOfPersonImages.Add("person5.jpg");
            lstOfPersonImages.Add("person4.jpg");
            lstOfPersonImages.Add("person2.jpg");
            personsimages.ItemsSource = lstOfPersonImages;
        }
    }
}