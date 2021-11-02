using System;
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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace _5Games_Ass1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Lotto : Page
    {
        Sound Lotto_Sound = new Sound();
        public Lotto()
        {
            this.InitializeComponent();
        }

        private void ButtonSelect_Click(object sender, RoutedEventArgs e)
        {
            Lotto_Sound.Lotto_Sound();
            img_deco.Source = new BitmapImage(new Uri("ms-appx:///Assets/Lotto/LottoEffect.gif", UriKind.RelativeOrAbsolute));
            img_deco.Visibility = Visibility.Visible;
            Lotto_Class row;
            int luckyDips;      // A variable of type integer called Lucky Dips
            row = new Lotto_Class();

            luckyDips = Convert.ToInt32(NumberBox.Text);

            TextBlockTicket.Text = "";
            TextBlockTicket.Text = TextBlockTicket.Text + "  ----------------------------------------------------\n";
            TextBlockTicket.Text = TextBlockTicket.Text + "  ----------------------------------------------------\n";

            TextBlockTicket.Text = TextBlockTicket.Text + "  --                                          Power     -- \n";
            TextBlockTicket.Text = TextBlockTicket.Text + "  --                                           ball         -- \n";
            TextBlockTicket.Text = TextBlockTicket.Text + "  --                                                         -- \n";

            if ( luckyDips < 21)        // Limit range of tickets 1 to 20
            {
                for (int i = 1;  i <= luckyDips; i++)        
                {
                    
                    TextBlockTicket.Text = TextBlockTicket.Text + "  --        ";
                    row.SetNumbersToZero();
                    row.GenerateNumbers();
                    row.SortNumbers();
                    row.PrintNumbers(TextBlockTicket);      //Print lottonumber
                    row.GeneratePower();
                    row.PrintSign(TextBlockTicket);     //Print sign
                    row.PrintPower(TextBlockTicket);      //Print powerball

                    TextBlockTicket.Text = TextBlockTicket.Text + "         --  \n";
                }

            }
            else
            {
                TextBlockTicket.Text = " Please enter less than 20 ";
            }

            TextBlockTicket.Text = TextBlockTicket.Text + " ----------------------------------------------------\n";
            TextBlockTicket.Text = TextBlockTicket.Text + " ----------------------------------------------------\n";

        }

    }
}
