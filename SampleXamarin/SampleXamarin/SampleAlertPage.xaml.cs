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
    public partial class SampleAlertPage : ContentPage
    {
        public SampleAlertPage()
        {
            InitializeComponent();
        }

        private async void btnAlert_Clicked(object sender, EventArgs e)
        {
            var jawab = await DisplayAlert("Question?", "Benar akan mendelete data?", "Yes", "No");
            if (jawab)
                await DisplayAlert("Keterangan", "Jawab Yes", "OK");
            else
                await DisplayAlert("Keterangan", "Jawab No", "OK");
        }

        private async void btnActionSheet_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Action Sheet: Send To?", "Cancel", null,
                "FB", "Twitter", "Instagram");
            await DisplayAlert("Test", $"Action: {action}", "OK");
        }
    }
}