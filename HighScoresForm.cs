using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Imaging;

namespace MemoryCardGame
{
    public partial class HighScoresForm : Form
    {
        public HighScoresForm()
        {
            InitializeComponent();
            this.BackColor = Color.Lavender;
            this.Font = new Font("Segoe UI", 9);
            this.Text = "🏆 Champion's Hall 🏆";
            SetupDataGridView();

            // Load scores when tab changes
            tabControlDifficulties.SelectedIndexChanged += TabControlDifficulties_SelectedIndexChanged;

            // Load initial scores (default to first tab)
            LoadScoresForDifficulty("Easy");

        }

        private void TabControlDifficulties_SelectedIndexChanged(object sender, EventArgs e)
        {
            string difficulty = tabControlDifficulties.SelectedTab.Text;
            LoadScoresForDifficulty(difficulty);
        }


        private void SetupDataGridView()
        {
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;

            // Header styling
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Row styling
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 9); // Supports emoji
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

            // Grid lines
            dataGridView1.GridColor = Color.LightGray;

            // Selection style
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }



        private void LoadScoresForDifficulty(string difficulty)
        {
            var allScores = HighScore.LoadScores();
            var filteredScores = allScores
                .Where(s => s.Difficulty.Equals(difficulty, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(s => s.Score)
                .Select((s, i) => new
                {
                    Rank = GetRankIcon(i + 1),
                    s.PlayerName,
                    s.Score,
                    Pairs = s.Pairs,
                    Attempts = s.Attempts,
                    Time = s.TimeTaken.ToString(@"mm\:ss"),
                    Date = s.Date.ToShortDateString()
                })
                .ToList();

            dataGridView1.DataSource = filteredScores;
            dataGridView1.ClearSelection();
        }


        private string GetRankIcon(int rank)
        {
            switch (rank)
            {
                case 1: return "🥇";
                case 2: return "🥈";
                case 3: return "🥉";
                default: return rank.ToString();
            }
        }




        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}