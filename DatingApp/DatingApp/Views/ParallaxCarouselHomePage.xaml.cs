using DatingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParallaxCarouselHomePage : ContentPage
    {
        List<ProfilesDetails> LstOfProfiles { get; set; } = new List<ProfilesDetails>();
        public ParallaxCarouselHomePage()
        {
            InitializeComponent();
            LstOfProfiles.Add(new ProfilesDetails() { Name="Sravani Royal", ProfilePic= "person1.jpg" });
            LstOfProfiles.Add(new ProfilesDetails() { Name="Srivani" ,ProfilePic= "person2.jpg" });
            LstOfProfiles.Add(new ProfilesDetails() { Name = "Srivani", ProfilePic = "person3.jpg" });
            LstOfProfiles.Add(new ProfilesDetails() { Name = "Srivani", ProfilePic = "person4.jpg" });
            LstOfProfiles.Add(new ProfilesDetails() { Name = "Srivani", ProfilePic = "person5.jpg" });
            LstOfProfiles.Add(new ProfilesDetails() { Name = "Srivani", ProfilePic = "person1.jpg" });
            LstOfProfiles.Add(new ProfilesDetails() { Name = "Anthony", ProfilePic = "person4.jpg" });
            LstOfProfiles.Add(new ProfilesDetails() { Name = "Nillcon", ProfilePic = "person3.jpg" });
            carousel.ItemsSource = LstOfProfiles;
        }
    }
}