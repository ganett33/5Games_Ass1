using System;
using System.Threading;
using Windows.Media.Core;
using Windows.Media.Playback;

namespace _5Games_Ass1.Data
{
    class Sound
    {
        private MediaPlayer player = new MediaPlayer();

        public async void Main_Sound(bool playing, MediaPlayer player)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Media");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("main_bg.mp3");
            player.AutoPlay = true;
            player.Source = MediaSource.CreateFromStorageFile(file);
            playing = true; 
        }

        public async void Dice_Roll()
        {
            //Initionalized Sound 
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Media");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Rolling Dice.mp3");
            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();      //Sound on
            Thread.Sleep(2000);         //Delay 2 sec;
        }

        public async void Slot_SoundSpin()
        {
            //Initionalized Sound 
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Media");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Spin.mp3");
            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();      //Sound on
            Thread.Sleep(2000);         //Delay 2 sec;
        }

        public async void Slot_SoundCoin()
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Media");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Coin.mp3");
            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();
            Thread.Sleep(1000);      //Delay 1 sec;
        }


        public async void Slot_SoundJackpot()
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Media");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Jackpot.mp3");
            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();
            Thread.Sleep(1000);      //Delay 1 sec;
        }

        public async void Slot_SoundNormal()
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Media");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Stop.mp3");
            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();
            Thread.Sleep(1000);      //Delay 1 sec;
        }
        public async void Slot_SoundGameOver()
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Media");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Gameover.mp3");
            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();
            Thread.Sleep(1000);      //Delay 1 sec;
        }

        public async void Lotto_Sound()
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Media");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Good Luck.mp3");
            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();
            Thread.Sleep(2000);         //Delay 2 sec;
        }
    }
}
