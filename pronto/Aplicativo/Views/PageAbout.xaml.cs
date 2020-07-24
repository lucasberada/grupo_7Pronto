﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicativo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAbout : ContentPage
    {
        public PageAbout()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new PrincipalView());
        }
    }
}