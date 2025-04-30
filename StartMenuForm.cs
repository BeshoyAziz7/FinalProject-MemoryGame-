using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCardGame
{
    public partial class StartMenuForm : Form
    {
        private SoundPlayer backgroundMusicPlayer;
        private bool isMuted = false;



        public StartMenuForm()
        {
            backgroundMusicPlayer = new SoundPlayer("Music/Ring04.wav");
            backgroundMusicPlayer.LoadAsync();
            backgroundMusicPlayer.PlayLooping();
            InitializeComponent();


        }



        public int SelectedDifficulty { get; private set; } = 12; // Default medium

        private void UpdateDifficultySelection()
        {
            if (radioEasy.Checked) SelectedDifficulty = 8;
            else if (radioMedium.Checked) SelectedDifficulty = 12;
            else if (radioHard.Checked) SelectedDifficulty = 16;
        }

        private void radioEasy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDifficultySelection();
        }

        private void radioMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDifficultySelection();
        }

        private void radioHard_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDifficultySelection();
        }







        private void btnStart_Click(object sender, EventArgs e)
        {

            UpdateDifficultySelection(); // <-- add this line!
            backgroundMusicPlayer?.Stop();
            using (MemoryGameForm gameForm = new MemoryGameForm(SelectedDifficulty))
            {
                this.Hide();
                var result = gameForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    backgroundMusicPlayer = new SoundPlayer("Music/Ring04.wav");
                    backgroundMusicPlayer.LoadAsync();
                    backgroundMusicPlayer.PlayLooping();
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnHighScores_Click(object sender, EventArgs e)
        {
            using (var form = new HighScoresForm())
            {
                form.ShowDialog();
            }
        }

        private void btnViewHighScores_Click(object sender, EventArgs e)
        {
            using (HighScoresForm scoresForm = new HighScoresForm())
            {
                scoresForm.ShowDialog();
            }

        }

        private void btnMuteUnmute_Click(object sender, EventArgs e)
        {
            if (!isMuted)
            {
                backgroundMusicPlayer?.Stop();
                btnMuteUnmute.Text = "🎶";
                isMuted = true;
            }
            else
            {
                backgroundMusicPlayer?.PlayLooping();
                btnMuteUnmute.Text = "🔕";
                isMuted = false;
            }

        }
    }
}
