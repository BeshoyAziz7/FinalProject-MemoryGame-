using System;
using System.Windows.Forms;

namespace MemoryCardGame
{
    public partial class HighScoreForm : Form
    {
        public string PlayerName { get; private set; }
        private readonly HighScore score;

        public HighScoreForm(HighScore score)
        {
            InitializeComponent();
            this.score = score;
            lblScore.Text = $"Your Score: {score.Score}";
            lblDetails.Text = $"{score.Pairs} pairs in {score.TimeTaken:mm\\:ss} with {score.Attempts} attempts";
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            PlayerName = txtName.Text.Trim();
            if (string.IsNullOrEmpty(PlayerName))
            {
                MessageBox.Show("Please enter your name!");
                return;
            }
            this.DialogResult = DialogResult.OK; // Set dialog result first
            this.Close(); // Then close

        }
    }
}