﻿using System;
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
                if (location != null)
                {
                    await DisplayAlert("Info GeoLoc",
                        $"Latitude:{location.Latitude} Longitude:{location.Longitude} Altitude: {location.Altitude}", "OK");
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