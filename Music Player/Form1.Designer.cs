namespace Music_Player
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnShuffleEnabled = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelVolumeNum = new System.Windows.Forms.Label();
            this.btnShuffleDisabled = new System.Windows.Forms.Button();
            this.listBoxAllSongs = new System.Windows.Forms.ListBox();
            this.labelAllSongs = new System.Windows.Forms.Label();
            this.labelShuffleEnabled = new System.Windows.Forms.Label();
            this.labelShuffleDisabled = new System.Windows.Forms.Label();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.labelShuffle = new System.Windows.Forms.Label();
            this.textBoxSongName = new System.Windows.Forms.TextBox();
            this.toolTipPlaySong = new System.Windows.Forms.ToolTip(this.components);
            this.labelBackslash = new System.Windows.Forms.Label();
            this.labelCurrentSongTime = new System.Windows.Forms.Label();
            this.labelSongDuration = new System.Windows.Forms.Label();
            this.btnSpeechRecog = new System.Windows.Forms.Button();
            this.toolTipSpeechRecog = new System.Windows.Forms.ToolTip(this.components);
            this.btnMute = new System.Windows.Forms.Button();
            this.btnUnmute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(330, 79);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(74, 61);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(127, 79);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(74, 61);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(520, 79);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 61);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnShuffleEnabled
            // 
            this.btnShuffleEnabled.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffleEnabled.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffleEnabled.Image")));
            this.btnShuffleEnabled.Location = new System.Drawing.Point(535, 146);
            this.btnShuffleEnabled.Name = "btnShuffleEnabled";
            this.btnShuffleEnabled.Size = new System.Drawing.Size(45, 32);
            this.btnShuffleEnabled.TabIndex = 4;
            this.btnShuffleEnabled.UseVisualStyleBackColor = false;
            this.btnShuffleEnabled.Visible = false;
            this.btnShuffleEnabled.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(330, 79);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(74, 61);
            this.btnPause.TabIndex = 5;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(710, 31);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(45, 176);
            this.trackBarVolume.TabIndex = 8;
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(678, 222);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(50, 15);
            this.labelVolume.TabIndex = 9;
            this.labelVolume.Text = "Volume:";
            // 
            // labelVolumeNum
            // 
            this.labelVolumeNum.AutoSize = true;
            this.labelVolumeNum.Location = new System.Drawing.Point(736, 222);
            this.labelVolumeNum.Name = "labelVolumeNum";
            this.labelVolumeNum.Size = new System.Drawing.Size(13, 15);
            this.labelVolumeNum.TabIndex = 10;
            this.labelVolumeNum.Text = "0";
            this.labelVolumeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShuffleDisabled
            // 
            this.btnShuffleDisabled.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffleDisabled.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffleDisabled.Image")));
            this.btnShuffleDisabled.Location = new System.Drawing.Point(535, 146);
            this.btnShuffleDisabled.Name = "btnShuffleDisabled";
            this.btnShuffleDisabled.Size = new System.Drawing.Size(45, 32);
            this.btnShuffleDisabled.TabIndex = 11;
            this.btnShuffleDisabled.UseVisualStyleBackColor = false;
            this.btnShuffleDisabled.Click += new System.EventHandler(this.btnShuffleDisabled_Click);
            // 
            // listBoxAllSongs
            // 
            this.listBoxAllSongs.FormattingEnabled = true;
            this.listBoxAllSongs.ItemHeight = 15;
            this.listBoxAllSongs.Location = new System.Drawing.Point(12, 222);
            this.listBoxAllSongs.Name = "listBoxAllSongs";
            this.listBoxAllSongs.Size = new System.Drawing.Size(506, 214);
            this.listBoxAllSongs.TabIndex = 12;
            this.toolTipPlaySong.SetToolTip(this.listBoxAllSongs, "Double-click on a song to play!");
            this.listBoxAllSongs.DoubleClick += new System.EventHandler(this.listBoxAllSongs_DoubleClick);
            // 
            // labelAllSongs
            // 
            this.labelAllSongs.AutoSize = true;
            this.labelAllSongs.Location = new System.Drawing.Point(12, 192);
            this.labelAllSongs.Name = "labelAllSongs";
            this.labelAllSongs.Size = new System.Drawing.Size(42, 15);
            this.labelAllSongs.TabIndex = 13;
            this.labelAllSongs.Text = "Songs:";
            // 
            // labelShuffleEnabled
            // 
            this.labelShuffleEnabled.AutoSize = true;
            this.labelShuffleEnabled.Location = new System.Drawing.Point(535, 181);
            this.labelShuffleEnabled.Name = "labelShuffleEnabled";
            this.labelShuffleEnabled.Size = new System.Drawing.Size(49, 15);
            this.labelShuffleEnabled.TabIndex = 15;
            this.labelShuffleEnabled.Text = "Enabled";
            // 
            // labelShuffleDisabled
            // 
            this.labelShuffleDisabled.AutoSize = true;
            this.labelShuffleDisabled.Location = new System.Drawing.Point(535, 181);
            this.labelShuffleDisabled.Name = "labelShuffleDisabled";
            this.labelShuffleDisabled.Size = new System.Drawing.Size(52, 15);
            this.labelShuffleDisabled.TabIndex = 16;
            this.labelShuffleDisabled.Text = "Disabled";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshList.Location = new System.Drawing.Point(524, 415);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(85, 23);
            this.btnRefreshList.TabIndex = 17;
            this.btnRefreshList.Text = "Refresh list";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // labelShuffle
            // 
            this.labelShuffle.AutoSize = true;
            this.labelShuffle.Location = new System.Drawing.Point(482, 181);
            this.labelShuffle.Name = "labelShuffle";
            this.labelShuffle.Size = new System.Drawing.Size(47, 15);
            this.labelShuffle.TabIndex = 18;
            this.labelShuffle.Text = "Shuffle:";
            // 
            // textBoxSongName
            // 
            this.textBoxSongName.Location = new System.Drawing.Point(127, 31);
            this.textBoxSongName.Name = "textBoxSongName";
            this.textBoxSongName.Size = new System.Drawing.Size(467, 23);
            this.textBoxSongName.TabIndex = 19;
            this.textBoxSongName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBackslash
            // 
            this.labelBackslash.AutoSize = true;
            this.labelBackslash.Location = new System.Drawing.Point(361, 155);
            this.labelBackslash.Name = "labelBackslash";
            this.labelBackslash.Size = new System.Drawing.Size(12, 15);
            this.labelBackslash.TabIndex = 21;
            this.labelBackslash.Text = "/";
            // 
            // labelCurrentSongTime
            // 
            this.labelCurrentSongTime.AutoSize = true;
            this.labelCurrentSongTime.Location = new System.Drawing.Point(330, 155);
            this.labelCurrentSongTime.Name = "labelCurrentSongTime";
            this.labelCurrentSongTime.Size = new System.Drawing.Size(34, 15);
            this.labelCurrentSongTime.TabIndex = 14;
            this.labelCurrentSongTime.Text = "00:00";
            // 
            // labelSongDuration
            // 
            this.labelSongDuration.AutoSize = true;
            this.labelSongDuration.Location = new System.Drawing.Point(370, 155);
            this.labelSongDuration.Name = "labelSongDuration";
            this.labelSongDuration.Size = new System.Drawing.Size(34, 15);
            this.labelSongDuration.TabIndex = 20;
            this.labelSongDuration.Text = "00:00";
            // 
            // btnSpeechRecog
            // 
            this.btnSpeechRecog.BackColor = System.Drawing.Color.Transparent;
            this.btnSpeechRecog.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeechRecog.Image")));
            this.btnSpeechRecog.Location = new System.Drawing.Point(524, 222);
            this.btnSpeechRecog.Name = "btnSpeechRecog";
            this.btnSpeechRecog.Size = new System.Drawing.Size(56, 54);
            this.btnSpeechRecog.TabIndex = 22;
            this.toolTipSpeechRecog.SetToolTip(this.btnSpeechRecog, "Say the Band Name + Song Name\r\n\r\n");
            this.btnSpeechRecog.UseVisualStyleBackColor = false;
            this.btnSpeechRecog.Click += new System.EventHandler(this.buttonSpeechRecog_Click);
            // 
            // btnMute
            // 
            this.btnMute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMute.Location = new System.Drawing.Point(680, 240);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(75, 23);
            this.btnMute.TabIndex = 23;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnUnmute
            // 
            this.btnUnmute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUnmute.Location = new System.Drawing.Point(680, 240);
            this.btnUnmute.Name = "btnUnmute";
            this.btnUnmute.Size = new System.Drawing.Size(75, 23);
            this.btnUnmute.TabIndex = 24;
            this.btnUnmute.Text = "Unmute";
            this.btnUnmute.UseVisualStyleBackColor = true;
            this.btnUnmute.Click += new System.EventHandler(this.btnUnmute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnmute);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnSpeechRecog);
            this.Controls.Add(this.labelBackslash);
            this.Controls.Add(this.labelSongDuration);
            this.Controls.Add(this.textBoxSongName);
            this.Controls.Add(this.labelShuffle);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.labelShuffleDisabled);
            this.Controls.Add(this.labelShuffleEnabled);
            this.Controls.Add(this.labelCurrentSongTime);
            this.Controls.Add(this.labelAllSongs);
            this.Controls.Add(this.listBoxAllSongs);
            this.Controls.Add(this.btnShuffleDisabled);
            this.Controls.Add(this.labelVolumeNum);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnShuffleEnabled);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPlay;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnShuffleEnabled;
        private Button btnPause;
        private TrackBar trackBarVolume;
        private Label labelVolume;
        private Label labelVolumeNum;
        private Button btnShuffleDisabled;
        private ListBox listBoxAllSongs;
        private Label labelAllSongs;
        private Label labelShuffleEnabled;
        private Label labelShuffleDisabled;
        private Button btnRefreshList;
        private Label labelShuffle;
        private TextBox textBoxSongName;
        private ToolTip toolTipPlaySong;
        private Label labelBackslash;
        private Label labelCurrentSongTime;
        private Label labelSongDuration;
        private Button btnSpeechRecog;
        private ToolTip toolTipSpeechRecog;
        private Button btnMute;
        private Button btnUnmute;
    }
}