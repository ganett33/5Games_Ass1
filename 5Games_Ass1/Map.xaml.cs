using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using Windows.Devices.Geolocation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace _5Games_Ass1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Map : Page
    {
        public Map()
        {
            this.InitializeComponent();
            MapControl.Loaded += MapControl_Loaded;
            MapControl.MapTapped += MapControl_MapTapped;
        }
        private void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            MapControl.Center =
                new Geopoint(new BasicGeoposition()
                {
                    //Geopoint for tauranga
                    Latitude = -37.6963072,
                    Longitude = 176.15749119999998
                });
            MapControl.ZoomLevel = 12;
        }

        private void TrafficCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MapControl.TrafficFlowVisible = true;
        }
        private void TrafficCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MapControl.TrafficFlowVisible = false;
        }
        private async void MapControl_MapTapped(
            Windows.UI.Xaml.Controls.Maps.MapControl sender,
            Windows.UI.Xaml.Controls.Maps.MapInputEventArgs args)
        {
            var tappedGeoPosition = args.Location.Position;
            string status =
                $"You at \nLatitude: {tappedGeoPosition.Latitude}" +
                $"\nLongtitude: {tappedGeoPosition.Longitude}";
            var messageDialog = new MessageDialog(status);
            await messageDialog.ShowAsync();
        }

        private void btn_Mapstyle_Click(object sender, RoutedEventArgs e)
        {
            if (MapControl.Style == Windows.UI.Xaml.Controls.Maps.MapStyle.Aerial)
            {
                MapControl.Style = Windows.UI.Xaml.Controls.Maps.MapStyle.Road;
                btn_Mapstyle.Content = "Aerial";
            }
            else
            {
                MapControl.Style = Windows.UI.Xaml.Controls.Maps.MapStyle.Aerial;
                btn_Mapstyle.Content = "Road";
            }
        }
    }
}
