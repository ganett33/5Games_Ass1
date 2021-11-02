using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using _5Games_Ass1;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Media.Core;
using Windows.Media.Playback;
using _5Games_Ass1.Data;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _5Games_Ass1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool playing= true;
        Sound main_Sound = new Sound();
        private MediaPlayer player = new MediaPlayer();
        public MainPage()
        {
            this.InitializeComponent();
            Logo_banner.Source = new BitmapImage(new Uri("ms-appx:///Assets/logoOut.png", UriKind.RelativeOrAbsolute));

        }

        private void btnHamburger_Click(object sender, RoutedEventArgs e)
        {
            this.MySplitView.IsPaneOpen =
                this.MySplitView.IsPaneOpen ? false : true;
        }

        private void radioBtn_PaneItem_Click(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                if (radioButton != null)
                {
                    switch (radioButton.Tag.ToString())
                    {
                        case "Main":
                            this.Frame.Navigate(typeof(MainPage));
                            break;
                    }
                }
                switch (radioButton.Tag.ToString())
                {
                    case "Dice":
                        MainFrame.Navigate(typeof(Dice));
                        break;

                    case "Drinks":
                        MainFrame.Navigate(typeof(Drinks));
                        break;

                    case "Lotto":
                        MainFrame.Navigate(typeof(Lotto));
                        break;

                    case "Prediction":
                        MainFrame.Navigate(typeof(Prediction));
                        break;

                    case "Slot":
                        MainFrame.Navigate(typeof(Slot));
                        break;

                    case "Map":
                        MainFrame.Navigate(typeof(Map));
                        break;
                }
                MySplitView.IsPaneOpen = false;
            }
        }

        private void btn_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            var button = sender as Button;

            if (button != null)
            {
                switch (button.Tag.ToString())
                {
                    case "Dice":
                        MainFrame.Navigate(typeof(Dice));
                        break;

                    case "Drinks":
                        MainFrame.Navigate(typeof(Drinks));
                        break;

                    case "Lotto":
                        MainFrame.Navigate(typeof(Lotto));
                        break;

                    case "Prediction":
                        MainFrame.Navigate(typeof(Prediction));
                        break;

                    case "Slot":
                        MainFrame.Navigate(typeof(Slot));
                        break;

                    case "Map":
                        MainFrame.Navigate(typeof(Map));
                        break;
                }
            }
        }


        private void toggleBTN_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;

            if (toggleSwitch != null)
            {
                if (playing)
                {
                    player.Source = null;
                    playing = false;


                }
                else
                {
                    main_Sound.Main_Sound(playing, player);
                    playing = true;
                }
            }
            
        }
    }
}
