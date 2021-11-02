using System;
using System.Collections;
using System.Collections.Generic;
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
using System.Threading;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace _5Games_Ass1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Dice : Page
    {

        Dices rule = new Dices();
        Sound dice_Sound = new Sound();
        private Random rnd = new Random();

        #region Player 1

        int roll1, roll2, roll3, roll4;
        Boolean dice1flag = false, dice2flag = false, dice3flag = false, dice4flag = false;
        int rollP1;
        int player1Sum;
        int p1Total;
        #endregion


        #region Player 2

        int roll5, roll6, roll7, roll8;
        Boolean dice5flag = false, dice6flag = false, dice7flag = false, dice8flag = false;
        int rollP2;
        int player2Sum;
        int p2Total;
        #endregion

        public Dice()
        {
            this.InitializeComponent();

            imageDice1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/one.png", UriKind.RelativeOrAbsolute));
            imageDice2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/two.png", UriKind.RelativeOrAbsolute));
            imageDice3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/three.png", UriKind.RelativeOrAbsolute));
            imageDice4.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/four.png", UriKind.RelativeOrAbsolute));
            imageDice5.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/four.png", UriKind.RelativeOrAbsolute));
            imageDice6.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/three.png", UriKind.RelativeOrAbsolute));
            imageDice7.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/two.png", UriKind.RelativeOrAbsolute));
            imageDice8.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/one.png", UriKind.RelativeOrAbsolute));

            btn_player1Roll.Visibility = Visibility.Collapsed;
            btn_player2Roll.Visibility = Visibility.Collapsed;
            txt_Result.Text = " Choose the option " + "\nSudden Death: You have a only 1 chance to roll the dices!" + "\n\n Total War: You have 3 chances to roll dices, I will calculate total for you!";
        }

        #region Menu
        private void option_Click(object sender, RoutedEventArgs e)
        {
            img_animation.Source = new BitmapImage(new Uri("ms-appx:///Assets/Dice/tenor.gif", UriKind.RelativeOrAbsolute));
            var button = sender as Button;          
            if (button != null)
            {
                switch (button.Tag.ToString())      //Select options
                {
                    case "Sudden Death":
                        txt_Result.Text = " Sudden Death " + " Player 1 Start ";
                        rollP1 = 1;
                        rollP2 = 1;
                        btn_player1Roll.Visibility = Visibility.Visible;
                        img_animation.Visibility = Visibility.Visible;

                        break;


                    case "Total War":
                        txt_Result.Text = " Total War " + " Player 1 Start ";
                        rollP1 = 3;
                        rollP2 = 3;
                        btn_player1Roll.Visibility = Visibility.Visible;
                        img_animation.Visibility = Visibility.Visible;

                        break;
                }
            }
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            rule.ResetImage(imageDice1, imageDice2, imageDice3, imageDice4, imageDice5, imageDice6, imageDice7, imageDice8, btn_Reset);
            ResetHandle();
        }

        public void ResetHandle()
        {
            btn_player1Roll.IsEnabled = true;
            btn_player2Roll.IsEnabled = true;
            btn_player1Roll.Visibility = Visibility.Collapsed;
            btn_player2Roll.Visibility = Visibility.Collapsed;
            img_animation.Visibility = Visibility.Collapsed;
            txt_Result.Text = " Choose the options " ;
        }
        #endregion

        #region Player 1
        private void P1Roll_Click(object sender, RoutedEventArgs e)
        {
            dice_Sound.Dice_Roll();
            if (rollP1 <= 6)
            {
                roll1 = rnd.Next(1, 7);                     //Random number 
                roll2 = rnd.Next(1, 7);
                roll3 = rnd.Next(1, 7);
                roll4 = rnd.Next(1, 7);

                rule.Roll(dice1flag, imageDice1, roll1);                        //Roll dice
                rule.Roll(dice2flag, imageDice2, roll2);
                rule.Roll(dice3flag, imageDice3, roll3);
                rule.Roll(dice4flag, imageDice4, roll4);

                player1Sum = rule.Sum(roll1, roll2, roll3, roll4);                         //Get total
                p1Total += player1Sum;              //Get 3 times of rolls total

                rollP1++;       //Check rolls
                if (rollP1 == 6)        //When select the game, rollp1 = 3 
                {
                    btn_player1Roll.IsEnabled = false;
                    if (rollP2 == 6)
                    {
                        rule.Win(p1Total, p2Total);
                    }
                }
                else if (rollP1 == 2)        //When select the game, rollp1 = 1 
                {
                    btn_player1Roll.IsEnabled = false;
                    if (rollP2 == 2)
                    {
                        rule.Win(player1Sum, player2Sum);
                    }
                }
            }

            btn_player1Roll.Visibility = Visibility.Collapsed;
            btn_player2Roll.Visibility = Visibility.Visible;

            txt_Result.Text = " Player 2 Start ";


        }


        #endregion

        #region P1 Hold dice
        private void imageDice1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rule.Tapped(ref dice1flag, ref imageDice1);
        }

        private void imageDice2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rule.Tapped(ref dice2flag, ref imageDice2);
        }

        private void imageDice3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rule.Tapped(ref dice3flag, ref imageDice3);
        }

        private void imageDice4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rule.Tapped(ref dice4flag, ref imageDice4);
        }

        #endregion

        #region Player 2
        private void P2Roll_Click(object sender, RoutedEventArgs e)
        {
            dice_Sound.Dice_Roll();
                if (rollP2 <= 6)
                {
                    roll5 = rnd.Next(1, 7);         //Random number 
                    roll6 = rnd.Next(1, 7);
                    roll7 = rnd.Next(1, 7);
                    roll8 = rnd.Next(1, 7);

                    rule.Roll(dice5flag, imageDice5, roll5);                                //Roll dice
                    rule.Roll(dice6flag, imageDice6, roll6);
                    rule.Roll(dice7flag, imageDice7, roll7);
                    rule.Roll(dice8flag, imageDice8, roll8);
                                    
                    player2Sum = rule.Sum(roll5, roll6, roll7, roll8);      //Get total
                    p2Total += player2Sum;              //Get 3 times of rolls total
                    rollP2++;       //Check rolls

                    if (rollP2 == 6)        //When select the game rollp2, = 3
                    {
                        btn_player2Roll.IsEnabled = false;
                        if (rollP1 == 6)
                        {
                            rule.Win(p1Total, p2Total);
                            ResetHandle();
                        }

                    }
                else if (rollP2 == 2)       //When select the game rollp2, = 1 
                    {
                        btn_player2Roll.IsEnabled = false;
                        if (rollP1 == 2)
                        {
                            rule.Win(player1Sum, player2Sum);
                            ResetHandle();
                    }
                    }

                }

            btn_player2Roll.Visibility = Visibility.Collapsed;
            btn_player1Roll.Visibility = Visibility.Visible;

            txt_Result.Text = " Player 1 Start ";

        }
        #endregion

        #region P2 Hold dice
        private void imageDice5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rule.Tapped(ref dice5flag, ref imageDice5);
        }

        private void imageDice6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rule.Tapped(ref dice6flag, ref imageDice6);
        }

        private void imageDice7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rule.Tapped(ref dice7flag, ref imageDice7);
        }

        private void imageDice8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            rule.Tapped(ref dice8flag, ref imageDice8);
        }

        #endregion
    }
}