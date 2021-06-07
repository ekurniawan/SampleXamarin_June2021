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
            await Navigation.PushAsync(new ContohListView());
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
            await DisplayAlert("Add","Add Items","OK");
        }
    }
}