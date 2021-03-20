﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpScreen : ContentPage
    {
        public SignUpScreen()
        {
            InitializeComponent();
        }

        private void GoToBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void GoToGenderInformationPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GenderInformationPage());
        }
    }
}