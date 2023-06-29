using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class FormPlaylists : Form
    {
        string playlistsFilePath = @"C:\Users\PC\Desktop\AVG Music Player Songs\Playlists\Playlists.txt";
        List<string> allSongs = new List<string>();
        string songFolderPath;
        public FormPlaylists(ListBox.ObjectCollection listboxSongs, string songFolderPath)
        {
            InitializeComponent();

            if (!File.Exists(playlistsFilePath))
            {
                File.Create(playlistsFilePath);
            }

            this.allSongs = allSongs;
            this.songFolderPath = songFolderPath;
        }
    }
}
