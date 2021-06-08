using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace SampleXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeolocationPage : ContentPage
    {
        public GeolocationPage()
        {
            InitializeComponent();
        }

        private async void btnGeolocation_Clicked(object sender, EventArgs e)
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);
                double lat = location.Latitude;
                double lon = location.Longitude;
                if (location != null)
                {
                    await DisplayAlert("Info GeoLoc",
                        $"Latitude:{location.Latitude} Longitude:{location.Longitude} Altitude: {location.Altitude}", "OK");

                    var placemarks = await Geocoding.GetPlacemarksAsync(lat, lon);
                    var placemark = placemarks?.FirstOrDefault();
                    if (placemark!=null){
                        await DisplayAlert("Geocode", $"Area: {placemark.AdminArea}, Country Code:{placemark.CountryCode}, CountyName: {placemark.CountryName}, Local:{placemark.Locality}, SubLocality: {placemark.SubLocality} ", "OK");
                    }
                }


            }
            catch (FeatureNotSupportedException fnsEx)
            {
                await DisplayAlert("Error", fnsEx.Message, "OK");
            }
            catch (FeatureNotEnabledException fneEx)
            {
                await DisplayAlert("Error", fneEx.Message, "OK");
            }
            catch(PermissionException pEx)
            {
                await DisplayAlert("Error", pEx.Message, "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}