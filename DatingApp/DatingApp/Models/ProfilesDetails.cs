using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Models
{
   public class ProfilesDetails
    {
        public string Name{ get; set; }
        public string DisplayName{ get; set; }
        public string Age{ get; set; }
        public string Status{ get; set; }
        public string PhoneNumber{ get; set; }
        public string Email{ get; set; }
        public List<string> Hobies{ get; set; }
        public string ProfilePic{ get; set; }
    }
}
