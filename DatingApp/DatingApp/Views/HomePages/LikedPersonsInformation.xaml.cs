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
    public partial class LikedPersonsInformation : ContentPage
    {
        ObservableCollection<string> LstOflikedPersons { get; set; } = new ObservableCollection<string>();
        ObservableCollection<string> LstOfmessage { get; set; } = new ObservableCollection<string>();
        public LikedPersonsInformation()
        {
            InitializeComponent();

            LstOflikedPersons.Add("person1.jpg");//new Student(){Name="",Marks="70"}
            LstOflikedPersons.Add("person2.jpg");
            LstOflikedPersons.Add("person3.jpg");
            LstOflikedPersons.Add("person4.jpg");
            LstOflikedPersons.Add("person5.jpg");
            LstOflikedPersons.Add("person4.jpg");
            LstOflikedPersons.Add("person2.jpg");


            LstOfmessage.Add("person1.jpg");//new Student(){Name="",Marks="70"}
            LstOfmessage.Add("person2.jpg");
            LstOfmessage.Add("person3.jpg");
            LstOfmessage.Add("person4.jpg");
            LstOfmessage.Add("person5.jpg");
            LstOfmessage.Add("person4.jpg");
            LstOfmessage.Add("person2.jpg");


            hrlstlikedperons.ItemsSource = LstOflikedPersons;
            vrlistmessage.ItemsSource = LstOfmessage;
        }
    }
}