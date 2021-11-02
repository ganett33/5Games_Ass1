using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Popups;


namespace _5Games_Ass1.Data
{
    class Dices
    {
        private Random number = new Random();
        public void Roll(bool flag, Image image, int roll)
        {
            if (flag == false)
            {
                if (roll == 1) image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/one.png", UriKind.RelativeOrAbsolute));
                else if (roll == 2) image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/two.png", UriKind.RelativeOrAbsolute));
                else if (roll == 3) image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/three.png", UriKind.RelativeOrAbsolute));
                else if (roll == 4) image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice//four.png", UriKind.RelativeOrAbsolute));
                else if (roll == 5) image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/five.png", UriKind.RelativeOrAbsolute));
                else image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/six.png", UriKind.RelativeOrAbsolute));
            }

        }

        public void Play(ref bool buttonClicked, ref int roll)
        {
            if (buttonClicked == false) roll = number.Next(1, 7);
        }
      
        public void Tapped(ref bool flag, ref Image image)                 //reference to passing values
        {     
            if (flag == false)
            {
                flag = true;
                image.Opacity = 0.5f;
            }
            else
            {
                flag = false;
                image.Opacity = 1f;
            }
        }

        public void ResetImage(Image image1, Image image2, Image image3, Image image4, Image image5, Image image6, Image image7, Image image8, Button sender)
        {
            var button = sender as Button;
            if (button != null)
            {
                image1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/one.png", UriKind.RelativeOrAbsolute));
                image2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/two.png", UriKind.RelativeOrAbsolute));
                image3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/three.png", UriKind.RelativeOrAbsolute));
                image4.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/four.png", UriKind.RelativeOrAbsolute));
                image5.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/four.png", UriKind.RelativeOrAbsolute));
                image6.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/three.png", UriKind.RelativeOrAbsolute));
                image7.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/two.png", UriKind.RelativeOrAbsolute));
                image8.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/one.png", UriKind.RelativeOrAbsolute));
            }
        }

        public int Sum(int roll1, int roll2, int roll3, int roll4)
        {
            int total = roll1 + roll2 + roll3 + roll4;
            return total;

        }

        public async void Win(int p1Sum, int p2Sum)
        {
            if (p1Sum > p2Sum)
            {
                ContentDialog win = new ContentDialog()
                {
                    Title = "🎈 Winner is player 1 !",
                    Content = "Player1 got " + p1Sum + " Points " + "\nPlayer2 got " + p2Sum + " Points " + "\n\nPress Reset button & Choose options",
                    CloseButtonText = "Cool" 
                };
                await win.ShowAsync();
            }
            else if (p1Sum == p2Sum)
            {
                ContentDialog win = new ContentDialog()
                {
                    Title = "🤦‍♂️🤦‍♀ You both are Loser ",
                    Content = "Player1 got " + p1Sum +" Points " + "\nPlayer2 got " + p2Sum +" Points " + "\n\nPress Reset button & Choose options",
                    CloseButtonText = "Cool"
                };
                await win.ShowAsync();
            }
            else
            {
                ContentDialog win = new ContentDialog()
                {
                    Title = "🎈 Winner is player 2 !",
                    Content = "Player1 got " + p1Sum + " Points " + "\nPlayer2 got " + p2Sum + " Points " + "\n\nPress Reset button & Choose options",
                    CloseButtonText = "Cool"
                };
                await win.ShowAsync();
            }
        }


        
        

    }
}
