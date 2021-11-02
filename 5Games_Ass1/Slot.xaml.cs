using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using _5Games_Ass1.Data;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace _5Games_Ass1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class Slot : Page
    {
        //Instance variables
        int dollars;       // Variable to store the dollars        
        int wheel1, wheel2, wheel3;                // Variable to store the dice roll
        Boolean loadUp = true;
        Boolean wheel1Clicked = false, wheel2Clicked = false, wheel3Clicked = false;          // Variable to store if the wheel was clicked      
        Slot_Func slot_Func = new Slot_Func();
        Sound slot_Sound = new Sound();


        public Slot()
        {
            this.InitializeComponent();
            imageWheel1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win.png", UriKind.RelativeOrAbsolute));
            imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win.png", UriKind.RelativeOrAbsolute));
            imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win.png", UriKind.RelativeOrAbsolute));
            imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/img_Welcom.gif", UriKind.RelativeOrAbsolute));
            GameOver.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/LoseGame.jpg", UriKind.RelativeOrAbsolute));

            // Sets the startup of the game
            buttonPlay.Visibility = Visibility.Collapsed;
            GameOver.Visibility = Visibility.Collapsed;

        }

        private void imageWheel1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            wheel1Clicked = slot_Func.Tapped(imageWheel1, wheel1Clicked, dollars,buttonPlay);

        }
        private void imageWheel2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            wheel2Clicked = slot_Func.Tapped(imageWheel2, wheel2Clicked, dollars, buttonPlay);
        }
        private void imageWheel3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            wheel3Clicked = slot_Func.Tapped(imageWheel3, wheel3Clicked, dollars, buttonPlay);
        }

        private void buttonAddCash_Click(object sender, RoutedEventArgs e)
        {
            slot_Sound.Slot_SoundCoin();
            imagerightdeco.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/img_slot_godzilla.gif", UriKind.RelativeOrAbsolute));
            buttonAddCash.Visibility = Visibility.Collapsed;
            buttonAddCash.Visibility = Visibility.Visible;
            imagerightdeco.Visibility = Visibility.Visible;

            if (dollars > 0)                        // Only allow the user to play if they have credit
            {
                buttonPlay.Visibility = Visibility.Visible;
                GameOver.Visibility = Visibility.Collapsed;
            }
            dollars = dollars + 10;                                 //Add $10 to the total

            textBlockDollars.Text = "You have $ " + dollars;        //Display the dollars

        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            slot_Sound.Slot_SoundSpin();
            if (loadUp == true)               //Sets the start up of the game
            {
                wheel1Clicked = false;
                wheel2Clicked = false;
                wheel3Clicked = false;
                loadUp = false;
            }

            slot_Func.Play(ref wheel1Clicked, ref wheel1);           //Gnerate random wheel
            slot_Func.Play(ref wheel2Clicked, ref wheel2);
            slot_Func.Play(ref wheel3Clicked, ref wheel3);

            slot_Func.Roll(wheel1Clicked, imageWheel1, wheel1);       //Spin the wheel
            slot_Func.Roll(wheel2Clicked, imageWheel2, wheel2);
            slot_Func.Roll(wheel3Clicked, imageWheel3, wheel3);

            dollars = dollars - 1;                               // It costs $1 dollar to play

            slot_Func.Hold(ref wheel1Clicked, ref dollars);      // Charge $20 to hold
            slot_Func.Hold(ref wheel2Clicked, ref dollars);
            slot_Func.Hold(ref wheel3Clicked, ref dollars);



            // Set up the following game rules for the pay-outs
            imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/img_Welcom.gif",
                                                  UriKind.RelativeOrAbsolute));

            if (dollars <= 20)
            {
                if ((wheel1 == 6) && (wheel2 == 6) && (wheel3 == 6))    // Six – six – six: Win $100 display win image.
                {
                    slot_Sound.Slot_SoundJackpot();
                    dollars = dollars + 100;
                    imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/WinGame.gif",
                                                          UriKind.RelativeOrAbsolute));
                }
                else if ((wheel1 == 5) && (wheel2 == 5) && (wheel3 == 5))  // Five – five – five: Win $60 display win image.
                {
                    slot_Sound.Slot_SoundNormal();
                    dollars = dollars + 60;
                    imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win_Game.jpg",
                                                          UriKind.RelativeOrAbsolute));
                }
                else if ((wheel1 == 4) && (wheel2 == 4) && (wheel3 == 4))    // Four – four – four: Win $50 display win image.
                {
                    slot_Sound.Slot_SoundNormal();
                    dollars = dollars + 50;
                    imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win_Game.jpg",
                                                          UriKind.RelativeOrAbsolute));
                }
                else if ((wheel1 == 3) && (wheel2 == 3) && (wheel3 == 3))    // Three – three – three: Win $35 display win image.
                {
                    slot_Sound.Slot_SoundNormal();
                    dollars = dollars + 35;
                    imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win_Game.jpg",
                                                          UriKind.RelativeOrAbsolute));
                }
                else if ((wheel1 == 2) && (wheel2 == 2) && (wheel3 == 2))   // Two – two – two: Win $20 display win image.
                {
                    slot_Sound.Slot_SoundNormal();
                    dollars = dollars + 25;
                    imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win_Game.jpg",
                                                          UriKind.RelativeOrAbsolute));
                }

                else if ((wheel1 == 5) && (wheel2 == 5) && (wheel3 == 6))    // Five – five – six: Win $15 display win image.
                {
                    slot_Sound.Slot_SoundNormal();
                    dollars = dollars + 10;
                    imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win_Game.jpg",
                                                          UriKind.RelativeOrAbsolute));
                }
                else if ((wheel1 == 4) && (wheel2 == 4) && (wheel3 == 6))    // Four – four – six: Win $10 display win image.
                {
                    slot_Sound.Slot_SoundNormal();
                    dollars = dollars + 10;
                    imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win_Game.jpg",
                                                          UriKind.RelativeOrAbsolute));
                }
                else if ((wheel1 == 3) && (wheel2 == 3) && (wheel3 == 6))    // Three – three – six: Win $6 display win image.
                {
                    slot_Sound.Slot_SoundNormal();
                    dollars = dollars + 6;
                    imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win_Game.jpg",
                                                          UriKind.RelativeOrAbsolute));
                }
                else if ((wheel1 == 2) && (wheel2 == 2) && (wheel3 == 6))    // Two – two – six: Win $4 display win image.
                {
                    slot_Sound.Slot_SoundNormal();
                    dollars = dollars + 4;
                    imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/win_Game.jpg",
                                                          UriKind.RelativeOrAbsolute));
                }
                else if ((wheel1 == 1) || (wheel2 == 1) || (wheel3 == 1))    // Lose $15 for every one rolled on a wheel and display lose image.
                {
                    dollars = dollars - 10;
                    imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/Slot/lose_Game.jpg",
                                                          UriKind.RelativeOrAbsolute));
                }

            }


            //When money gets 0
            if (dollars <= 0)
            {
                slot_Sound.Slot_SoundGameOver();
                GameOver.Visibility = Visibility.Visible;
                imagerightdeco.Visibility = Visibility.Collapsed;
            }

            wheel1Clicked = false;                 // Reset the hold after play
            imageWheel1.Opacity = 1f;              // Reset the hold brightness after play            

            wheel2Clicked = false;                
            imageWheel2.Opacity = 1f;             

            wheel3Clicked = false;                
            imageWheel3.Opacity = 1f;             


            if (dollars <= 0)
            {
                buttonPlay.Visibility = Visibility.Collapsed;

                dollars = 0;

            }
            textBlockDollars.Text = "You have $ " + dollars;         // Display the dollars
        }

    }
}