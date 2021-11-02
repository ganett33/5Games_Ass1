using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml;


namespace _5Games_Ass1.Data
{
    class Slot_Func
    {
        private Random number = new Random();

        public void Roll(bool wheelClicked, Image image, int wheel)
        {            
            if (wheelClicked == false)
            {
                if (wheel == 1) image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/lose.png",
                                                                      UriKind.RelativeOrAbsolute));
                else if (wheel == 2) image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/img_Apple_Slot.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel == 3) image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/img_Cherry_Slot.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel == 4) image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/img_Gem_Slot.png",
                                                                           UriKind.RelativeOrAbsolute));
                else if (wheel == 5) image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/img_Heart_Slot.png",
                                                                           UriKind.RelativeOrAbsolute));
                else image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win.png",
                                                                  UriKind.RelativeOrAbsolute));
            }
        }

        public void Play(ref bool wheelClicked, ref int wheel)
        {
            if (wheelClicked == false) wheel = number.Next(1, 7);
        }

        public void Hold(ref bool wheelClicked, ref int dollars)
        {
            if (wheelClicked == true) dollars = dollars - 20;
        }

        public bool Tapped(Image imageWheel, bool wheelClicked, int dollars, Button button)
        {
            if (wheelClicked == false)
            {
                if (dollars <= 20)
                {
                    button.Visibility = Visibility.Collapsed;
                }
                imageWheel.Opacity = 0.5f;
                return true;

            }
            else
            {
                imageWheel.Opacity = 1f;
                button.Visibility = Visibility.Visible;
                return false;

            }

        }

    }

    
}
