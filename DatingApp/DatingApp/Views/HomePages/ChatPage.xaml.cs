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
    public partial class ChatPage : ContentPage
    {
        ObservableCollection<string> lstOflikedPersons { get; set; } = new ObservableCollection<string>();
        ObservableCollection<string> lstOfmessage { get; set; } = new ObservableCollection<string>();

        public ChatPage()
        {
            InitializeComponent();

            lstOflikedPersons.Add("person1.jpg");//new Student(){Name="",Marks="70"}
            lstOflikedPersons.Add("person2.jpg");
            lstOflikedPersons.Add("person3.jpg");
            lstOflikedPersons.Add("person4.jpg");
            lstOflikedPersons.Add("person5.jpg");
            lstOflikedPersons.Add("person4.jpg");
            lstOflikedPersons.Add("person2.jpg");


            lstOfmessage.Add("person1.jpg");//new Student(){Name="",Marks="70"}
            lstOfmessage.Add("person2.jpg");
            lstOfmessage.Add("person3.jpg");
            lstOfmessage.Add("person4.jpg");
            lstOfmessage.Add("person5.jpg");
            lstOfmessage.Add("person4.jpg");
            lstOfmessage.Add("person2.jpg");


            hrlstlikedperons.ItemsSource = lstOflikedPersons;
            vrlistmessage.ItemsSource = lstOfmessage;
        }
    }
}