﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SampleFlexPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
