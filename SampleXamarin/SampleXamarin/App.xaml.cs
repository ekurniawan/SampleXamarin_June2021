using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NavigasiPage1());
            //MainPage = new NavigationPage(new MyTabbedPage());
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Green;

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
