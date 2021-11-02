using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace _5Games_Ass1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Prediction : Page
    {
        string[] timeArray = new string[]
        {"thirty minutes","an hour", "eight hours", "twelve hours", "a day", "a week", "a month", "a year", "a decade"};
        string[] aspectArray = new string[]
        {"finances", "love life", "career prospects", "travel plans", "relationships"};
        string[] effectArray = new string[]
        {"fall apart", "exceed your expectation", "become awkward in an unexpected way", "become manageable", "become spectacular", "come to a positive outcome" };
        string[] personaArray = new string[]
        {"man", "boy", "woman", "girl", "dog", "bird", "hedgehog", "singer", "relative"};
        string[] featureArray = new string[]
        {"pink hair", "a broken golden chain ", "scary eyes", "long blond nose hair", "very red lips", "silver feet"};
        string[] consequenceArray = new string[]
        {"avoid looking at directly", "sing a sad song with", "stop and talk to", "dance with", "tell a secret", "buy a coffee"};

        SpeechSynthesizer reader;
        
        public Random number = new Random();
        public Prediction()
        {
            this.InitializeComponent();
            txt_Welcome.Visibility = Visibility.Visible;

            try
            {
                reader = new SpeechSynthesizer();
            }
            catch (System.IO.FileNotFoundException)
            {
                var messageDialog = new Windows.UI.Popups.MessageDialog("Media player components unavailable.\n You need to install a Voice Package in your Windows Settings.\n\nSettings > Time & Language > Speeach > Manage Voices > Add Voices");
                _ = messageDialog.ShowAsync();

            }
            catch (Exception)
            {
                media.AutoPlay = false;
                var messageDialog = new Windows.UI.Popups.MessageDialog("Unable to synthesize text");
                _ = messageDialog.ShowAsync();
            }

        }

        private void ButtonPrediction_Click(object sender, RoutedEventArgs e)
        {
            txt_Welcome.Visibility = Visibility.Collapsed;      //Welcome massge collapsed

            Effect1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Predic/blank.png", UriKind.RelativeOrAbsolute));
            Effect.Source = new BitmapImage(new Uri("ms-appx:///Assets/Predic/hand.png", UriKind.RelativeOrAbsolute));
            Thread.Sleep(1500);

            TextBlockPrediction.Text = "\n  Over a period of" + " " +
            timeArray[number.Next(0, timeArray.Length)] + " your " +
            aspectArray[number.Next(0, aspectArray.Length)] + " will  " +
            effectArray[number.Next(0, effectArray.Length)] + ". \n\n" +

            "  This will come to pass after you meet a " +
            personaArray[number.Next(0, personaArray.Length)] + " with " +
            featureArray[number.Next(0, featureArray.Length)] + " " +
            "who for some reason you find yourself obliged to " +
            consequenceArray[number.Next(0, consequenceArray.Length)];

            string Prediction = TextBlockPrediction.Text;
            Speak(Prediction);

            //Thread.Sleep(5000);
            //Effect.Visibility = Visibility.Collapsed;
            //Effect1.Visibility = Visibility.Collapsed;
            //TextBlockPrediction.Text = " ";

        }


        private async void Speak(string message)
        {
            var stream = await reader.SynthesizeTextToStreamAsync(message);
            media.SetSource(stream, stream.ContentType);

            media.Play();
        }
    }
}
