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
    public partial class NavigasiPage1 : ContentPage
    {
        public NavigasiPage1()
        {
            InitializeComponent();
        }

        private async void btnSimpleList_Clicked(object sender, EventArgs e)
        {
            var contohListViewPage = new ContohListView(entryPesan.Text);
            await Navigation.PushAsync(contohListViewPage);
        }

        private async void menuSimpleList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContohListView());
        }

        private async void menuImageList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewImagePage());
        }

        private async void menuViewCell_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Add", "Add Items", "OK");
        }

        private async void btnGlobalVar_Clicked(object sender, EventArgs e)
        {
            Global.Instance.myData = entryPesan.Text;
            await Navigation.PushAsync(new ListViewImagePage());
        }

        private async void btnAppCurrent_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Username"] = entryPesan.Text;
            await DisplayAlert("Keterangan", "App Current berhasil dibuat", "OK");

            await Navigation.PushAsync(new ListViewImagePage());
        }
    }
}