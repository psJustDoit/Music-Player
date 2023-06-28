using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using WMPLib;

namespace Music_Player
{
    public class MusicPlayer
    {
        WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();

        public MusicPlayer()
        {
            mediaPlayer.settings.volume = 50;
        }

        public int Volume
        {
            get { return mediaPlayer.settings.volume; }
            set { mediaPlayer.settings.volume = value; }
        }

        public IWMPMedia CurrentSong
        {
            get
            {
                return mediaPlayer.currentMedia;
            }
        }
        public void PlaySong(string path, string song)
        {
            mediaPlayer.URL = path + "\\" + song + ".mp3";
            mediaPlayer.controls.play();
        }

        public void PauseSong()
        {
            mediaPlayer.controls.pause();
        }

        public void ResumeSong()
        {
            mediaPlayer.controls.play();
        }

        public void StopSong()
        {
            mediaPlayer.controls.stop();
        }

        public void Close()
        {
            //Stop any current song
            mediaPlayer.controls.stop();
            mediaPlayer.close();
        }
    }
}
