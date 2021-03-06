using SampleXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContohListView : ContentPage
    {
        

        public ContohListView()
        {
            InitializeComponent();
            List<ListItem> lstItems = new List<ListItem>
            {
                new ListItem{Title="Attack on Titan",Description="Attack on titan series",
                Gambar="monyet1.png"},
                new ListItem{Title="Demon Slayer",Description="Demon Slayer series",
                Gambar="monyet1.png"},
                new ListItem{Title="Money Heist",Description="Money Heist series",
                Gambar="monyet1.png"}
            };
            listData.ItemsSource = lstItems;
        }

        private string _pesan;
        public ContohListView(string pesan)
        {
            _pesan = pesan;

            InitializeComponent();
            List<ListItem> lstItems = new List<ListItem>
            {
                new ListItem{Title="Attack on Titan",Description="Attack on titan series",
                Gambar="monyet1.png"},
                new ListItem{Title="Demon Slayer",Description="Demon Slayer series",
                Gambar="monyet1.png"},
                new ListItem{Title="Money Heist",Description="Money Heist series",
                Gambar="monyet1.png"}
            };
            listData.ItemsSource = lstItems;
        }

        private void listData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        private async void listData_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = ((ListView)sender).SelectedItem as ListItem;
            if (item == null)
                return;
            await DisplayAlert("Keterangan", $"Anda memilih: {item.Title}", "OK");
        }

        private async void btnListWithImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewImagePage());
        }

        private async void btnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btnPesan_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Pesan", $"Pesan: {_pesan}", "OK");
        }

        /*private void lstTest_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = ((ListView)sender).SelectedItem as string;
            if (item == null)
                return;

            DisplayAlert("Item Selected", $"Memilih item: {item}", "OK");
        }

        private void lstTest_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }*/
    }
}