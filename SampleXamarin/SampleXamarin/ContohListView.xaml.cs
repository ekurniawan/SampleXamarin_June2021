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

        private void listData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        private void listData_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = ((ListView)sender).SelectedItem as ListItem;
            if (item == null)
                return;
            DisplayAlert("Keterangan", $"Anda memilih: {item.Title}", "OK");
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