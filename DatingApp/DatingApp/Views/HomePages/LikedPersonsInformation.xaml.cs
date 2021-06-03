using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views.HomePages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LikedPersonsInformation : Shell
    {
        ObservableCollection<string> lstOflikedPersons { get; set; } = new ObservableCollection<string>();
        ObservableCollection<string> lstOfmessage { get; set; } = new ObservableCollection<string>();
        public LikedPersonsInformation()
        {
            InitializeComponent();

        
        }
    }
}