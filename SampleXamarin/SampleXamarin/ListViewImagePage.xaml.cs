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
    }
}