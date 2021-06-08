using SampleXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewImagePage : ContentPage
    {
        public ListViewImagePage()
        {
            InitializeComponent();
            List<ListItem> lstItems = new List<ListItem>
            {
                new ListItem{Title="Attack on Titan",Description="Attack on titan series",
                Gambar="monyet1.png"},
                new ListItem{Title="Demon Slayer",Description="Demon Slayer series",
                Gambar="monyet2.png"},
                new ListItem{Title="Money Heist",Description="Money Heist series",
                Gambar="monyet1.png"}
            };
            lstData.ItemsSource = lstItems;
        }

        private async void btnCekGlobal_Clicked(object sender, EventArgs e)
        {
            string data = Global.Instance.myData;
            await DisplayAlert("Global Var", data, "OK");
        }

        private async void btnAppCurrent_Clicked(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("Username"))
            {
                var username = Application.Current.Properties["Username"].ToString();
                await DisplayAlert("App Current", $"Username: {username}", "OK");
            }
            else
            {
                await DisplayAlert("Keterangan", "Tidak ditemukan", "OK");
            }
            
        }

        private async void btnPreferences_Clicked(object sender, EventArgs e)
        {
            if (Preferences.ContainsKey("password"))
            {
                var pass = Preferences.Get("password", string.Empty);
                await DisplayAlert("Preferences", $"Password: {pass}", "OK");
            }
        }
    }
}