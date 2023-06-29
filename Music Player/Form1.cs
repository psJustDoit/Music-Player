using System.Speech;
using System.Speech.Recognition;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        string songFolderPath = @"C:\Users\PC\Desktop\AVG Music Player Songs";
        string playlistsFolderPath = @"C:\Users\PC\Desktop\AVG Music Player Songs\Playlists";
        bool isShuffleEnabled = false;
        MusicPlayer player = new MusicPlayer();
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        Choices choices;
        GrammarBuilder grammarBuilder;
        Grammar grammar;

        //Used for mute/unmute
        int volumePrevValue;
        bool isMuted;

        public Form1()
        {
            InitializeComponent();

            //Create folder with songs if it does not exist already and create playlists folder
            if (!Directory.Exists(songFolderPath))
            {
                Directory.CreateDirectory(songFolderPath);
                Directory.CreateDirectory(playlistsFolderPath);
            }

            //Fill list box with songs from folder
            RefreshSongList();

            //Shuffle
            btnShuffleEnabled.Enabled = false;
            btnShuffleEnabled.Visible = false;
            labelShuffleEnabled.Visible = false;

            btnShuffleDisabled.Visible = true;
            btnShuffleDisabled.Enabled = true;
            labelShuffleDisabled.Visible = true;

            //Volume
            trackBarVolume.Value = player.Volume;

            //Play & Pause
            btnPause.Visible = true;
            btnPause.Enabled = true;

            btnPlay.Visible = false;
            btnPlay.Enabled = false;

            //Mute
            btnMute.Enabled = true;
            btnMute.Visible= true;

            btnUnmute.Enabled = false;
            btnUnmute.Visible = false;

            //Speech recognition
            RefreshSpeechRecogChoices();
        }  

        private void Recognizer_SpeechRecognized(object sender, RecognitionEventArgs e)
        {
            if (listBoxAllSongs.Items.Contains(e.Result.Text))
            {
                player.PlaySong(songFolderPath, e.Result.Text);
            }
        }
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            isShuffleEnabled = false;

            btnShuffleEnabled.Visible = false;
            btnShuffleEnabled.Enabled = false;

            btnShuffleDisabled.Enabled = true;
            btnShuffleDisabled.Visible = true;

            labelShuffleEnabled.Visible = false;
            labelShuffleDisabled.Visible = true;
        }

        private void btnShuffleDisabled_Click(object sender, EventArgs e)
        {
            isShuffleEnabled = true;

            btnShuffleDisabled.Visible = false;
            btnShuffleDisabled.Enabled = false;

            btnShuffleEnabled.Visible = true;
            btnShuffleEnabled.Enabled = true;

            labelShuffleDisabled.Visible = false;
            labelShuffleEnabled.Visible = true;
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshSongList();
            RefreshSpeechRecogChoices();
        }

        public void RefreshSpeechRecogChoices()
        {
            try
            {
                choices = new Choices(FillChoices());
                grammarBuilder = new GrammarBuilder(choices);
                grammar = new Grammar(grammarBuilder);
                recognizer.LoadGrammar(grammar);
            }
            catch(Exception ex)
            {
                //Song folder will be empty when first created
                //Do nothing if song folder is empty
            }
        }
        public void RefreshSongList()
        {
            listBoxAllSongs.Items.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(songFolderPath);
            FileInfo[] songs = directoryInfo.GetFiles("*.mp3");
            string songStr = "";

            foreach (FileInfo song in songs)
            {
                songStr = song.Name.Replace(".mp3", "");
                listBoxAllSongs.Items.Add(songStr);
            }
        }

        //Switch next song
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (isShuffleEnabled)
            {
                Random random = new Random();
                int randomVal = random.Next(0, listBoxAllSongs.Items.Count);
                string songName = listBoxAllSongs.Items[randomVal].ToString();
                player.PlaySong(songFolderPath, songName);
                ChangeCurrentSongName(listBoxAllSongs.Items[randomVal].ToString());
            }
            else
            {
                int currSongIndex = listBoxAllSongs.Items.IndexOf(textBoxSongName.Text);
                int nextSongIndex;
                if(currSongIndex == listBoxAllSongs.Items.Count - 1) 
                {
                    nextSongIndex = 0;
                }
                else
                {
                    nextSongIndex = currSongIndex + 1;
                }
                player.PlaySong(songFolderPath, listBoxAllSongs.Items[nextSongIndex].ToString());
                ChangeCurrentSongName(listBoxAllSongs.Items[nextSongIndex].ToString());
            }
        }

        //Play song on list box item double click
        private void listBoxAllSongs_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxAllSongs.SelectedItem != null)
            {
                player.PlaySong(songFolderPath, listBoxAllSongs.SelectedItem.ToString());
                ChangeCurrentSongName(listBoxAllSongs.SelectedItem.ToString());
            }
        }

        //Update text box to display song that is currently playing
        public void ChangeCurrentSongName(string songName)
        {
            textBoxSongName.Text = songName;
        }

        //Volume control
        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            int currVal = trackBarVolume.Value;
            player.Volume= currVal;
            labelVolumeNum.Text = currVal.ToString() + "%";
            if (isMuted)
            {
                btnMute.Visible = true;
                btnMute.Enabled = true;

                btnUnmute.Visible = false;
                btnUnmute.Enabled = false;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (CheckActiveSong())
            {
                player.PauseSong();

                btnPlay.Enabled = true;
                btnPlay.Visible = true;

                btnPause.Visible = false;
                btnPause.Enabled = false;
            }
            else
            {
                MessageBox.Show("No active song!");
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (CheckActiveSong())
            {
                player.ResumeSong();

                btnPause.Enabled = true;
                btnPause.Visible = true;

                btnPlay.Visible = false;
                btnPlay.Enabled = false;
            }
            else
            {
                MessageBox.Show("No active song!");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int currSongIndex = listBoxAllSongs.Items.IndexOf(textBoxSongName.Text);
            int prevSongIndex;
            if(currSongIndex == 0)
            {
                prevSongIndex = listBoxAllSongs.Items.Count - 1;
            }
            else
            {
                prevSongIndex = currSongIndex - 1; 
            }

            string songName = listBoxAllSongs.Items[prevSongIndex].ToString();
            player.PlaySong(songFolderPath, songName);
            ChangeCurrentSongName(songName);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Close();
        }

        private void buttonSpeechRecog_Click(object sender, EventArgs e)
        {
            //Pause a song and change buttons when speech detected
            if (player.CurrentSong != null)
            {
                player.PauseSong();
                btnPlay.Visible = true;
                btnPlay.Enabled = true;

                btnPause.Visible = false;
                btnPause.Enabled = false;
            }

            //Disable speech recognition button when talking and enable back when everything is done
            btnSpeechRecog.Enabled = false;

            recognizer.SetInputToDefaultAudioDevice();
            RecognitionResult result = recognizer.Recognize();
            VoicePlaySong(result);

            btnSpeechRecog.Enabled = true;
        }

        public bool CheckActiveSong()
        {
            string currSong = textBoxSongName.Text;
            if (currSong == "")
            {
                MessageBox.Show("No active song!");
                return false;
            }
            return true;
        }

        public void VoicePlaySong(RecognitionResult result)
        {
            string song = VoiceRecogFoundSong(result);
            if (song == "")
            {
                MessageBox.Show("Cannot find the song, please try speaking more clearly!");
            }
            else
            {
                player.PlaySong(songFolderPath, song.ToString());

                btnPause.Enabled = true;
                btnPause.Visible = true;

                btnPlay.Visible = false;
                btnPlay.Enabled = false;

                ChangeCurrentSongName(song.ToString());
            }
        }

        public string VoiceRecogFoundSong(RecognitionResult result)
        {
            if (result == null) return "";
            if(listBoxAllSongs.Items.Contains(result.Text))
            {
                int index = listBoxAllSongs.Items.IndexOf(result.Text);
                return listBoxAllSongs.Items[index].ToString();
            }
            return "";
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            btnUnmute.Visible = true;
            btnUnmute.Enabled = true;
            isMuted = true;

            volumePrevValue = player.Volume;
            player.Volume = 0;
            labelVolumeNum.Text = "Muted";

            btnMute.Enabled = false;
            btnMute.Visible = false;
        }

        private void btnUnmute_Click(object sender, EventArgs e)
        {
            btnMute.Enabled = true;
            btnMute.Visible = true;
            isMuted = false;

            player.Volume = volumePrevValue;
            volumePrevValue = 0;
            labelVolumeNum.Text = player.Volume.ToString();
            
            btnUnmute.Enabled = false;
            btnUnmute.Visible = false;
        }

        //Add all songs to choice list so speech recognition works properly
        public string[] FillChoices()
        {
            List<string> choiceList = new List<string>();
            foreach(var item in listBoxAllSongs.Items)
            {
                choiceList.Add(item.ToString());
            }

            return choiceList.ToArray();
        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            FormPlaylists formPlaylists = new FormPlaylists(listBoxAllSongs.Items, songFolderPath);
            formPlaylists.Show();
        }
    }
}