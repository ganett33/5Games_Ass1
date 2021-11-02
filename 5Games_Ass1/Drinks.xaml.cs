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
using Windows.UI.Xaml.Media.Imaging;
using Windows.Media.SpeechSynthesis;
using _5Games_Ass1.Data;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace _5Games_Ass1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Drinks : Page
    {
        private List<Drink> Drink;
        SpeechSynthesizer reader;
        public Drinks()
        {
            this.InitializeComponent();
            Drink = DrinksManager.GetDrinks();

            text_Recipe.Visibility = Visibility.Collapsed;
            btn_Recipe.Visibility = Visibility.Collapsed;
            rec_Recipe.Visibility = Visibility.Collapsed;

            text_Mix.Visibility = Visibility.Collapsed;
            btn_Mix.Visibility = Visibility.Collapsed;
            rec_Mix.Visibility = Visibility.Collapsed;

            try
            {
                reader = new SpeechSynthesizer();
            }
            catch (System.IO.FileNotFoundException)
            {
                var messageDialog = new Windows.UI.Popups.MessageDialog("Media player components unavailable.\n You need to install a Voice Package in your Windows Settings.\n\nSettings > Time & Language > Speeach > Manage Voices > Add Voices");
                _ = messageDialog.ShowAsync();

            }
            catch(Exception)
            {
                media.AutoPlay = false;
                var messageDialog = new Windows.UI.Popups.MessageDialog("Unable to synthesize text");
                _ = messageDialog.ShowAsync();
            }

        }

        private async void Speak(string message)
        {
            var stream = await reader.SynthesizeTextToStreamAsync(message);

            media.SetSource(stream, stream.ContentType);

            media.Play();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var drink = (Drink)e.ClickedItem;

            TextBlockRecipe.Text = drink.Recipe;
            TextBlockMix.Text = drink.Mix;

            text_Recipe.Visibility = Visibility.Visible;
            btn_Recipe.Visibility = Visibility.Visible;
            rec_Recipe.Visibility = Visibility.Visible;

            text_Mix.Visibility = Visibility.Visible;
            btn_Mix.Visibility = Visibility.Visible;
            rec_Mix.Visibility = Visibility.Visible;

        }

        private void btn_Recipe_Click(object sender, RoutedEventArgs e)
        {
            string ReadRecipe = TextBlockRecipe.Text;
            Speak(ReadRecipe);
        }

        private void btn_Mix_Click(object sender, RoutedEventArgs e)
        {
            string ReadMix = TextBlockMix.Text;
            Speak(ReadMix);
        }

    }
}

