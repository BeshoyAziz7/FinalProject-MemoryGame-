using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;


namespace MemoryCardGame
{
    public partial class MemoryGameForm : Form
    {
        private List<Card> cards = new List<Card>();
        private Card firstCard, secondCard;
        private int pairsFound = 0;
        private int attempts = 0;
        private readonly int totalPairs; // Change based on your image pairs
        private Stopwatch gameTimer = new Stopwatch();
        private HighScore currentGameScore = new HighScore();
        private SoundPlayer gameMusicPlayer;



        public MemoryGameForm(int totalPairs)
        {
            this.totalPairs = totalPairs;
            gameTimer.Restart();
            currentGameScore = new HighScore { Date = DateTime.Now };
            InitializeComponent();

            // Start playing different background music
            gameMusicPlayer = new SoundPlayer("Music/GameBackground.wav"); // <-- Your new music file
            gameMusicPlayer.LoadAsync();
            gameMusicPlayer.PlayLooping();



            this.FormClosing += MemoryGameForm_FormClosing;

            InitializeGame();
        }

        private void InitializeGame()
        {
            // Clear any existing cards
            flowLayoutPanel1.Controls.Clear();
            cards.Clear();

            int cardsPerRow = totalPairs <= 8 ? 4 : 6; // 4 columns for easy, 6 for medium/hard
            flowLayoutPanel1.Width = (100 + 10) * cardsPerRow; // card width + margin

            pairsFound = 0;
            attempts = 0;
            UpdateStatusLabel();

            // Load card back image
            Card.BackImage = Image.FromFile("Images/card_back.png");

            // Create a list of card values (pairs)
            List<int> cardValues = new List<int>();
            for (int i = 1; i <= totalPairs; i++) // Use totalPairs here
            {
                cardValues.Add(i);
                cardValues.Add(i); // Add each value twice
            }

            // Shuffle the card values
            Random rnd = new Random();
            for (int i = 0; i < cardValues.Count; i++)
            {
                int swapIndex = rnd.Next(cardValues.Count);
                int temp = cardValues[swapIndex];
                cardValues[swapIndex] = cardValues[i];
                cardValues[i] = temp;
            }

            // Create and add cards to the form
            for (int i = 0; i < cardValues.Count; i++)
            {
                Card card = new Card(totalPairs)
                {
                    Id = i,
                    Value = cardValues[i],
                    FrontImage = Image.FromFile($"Images/icon_{cardValues[i]}.png")
                };

                cards.Add(card);
                flowLayoutPanel1.Controls.Add(card);
                card.Flip(); // Show front initially
                card.Click += Card_Click;  // <-- Hook up the form-level click logic
            }

            // After 2 seconds, flip all cards face down
            Timer timer = new Timer { Interval = 2000 };
            timer.Tick += (s, e) =>
            {
                foreach (Card card in cards)
                {
                    card.Flip();
                }
                timer.Stop();
            };
            timer.Start();
        }

        private void UpdateStatusLabel()
        {
            labelStatus.Text = $"Pairs Found: {pairsFound}/{totalPairs} | Attempts: {attempts}";
        }

        private void Card_Click(object sender, EventArgs e)
        {
            // Prevent clicking more than 2 cards or matched cards
            if (firstCard != null && secondCard != null)
                return;

            Card clickedCard = sender as Card;
            if (clickedCard == null || clickedCard.IsMatched || clickedCard.IsFlipped)
                return;

            clickedCard.Flip();

            if (firstCard == null)
            {
                firstCard = clickedCard;
                return;
            }

            secondCard = clickedCard;
            attempts++;
            UpdateStatusLabel();

            // Check for match
            if (firstCard.Value == secondCard.Value)
            {
                firstCard.IsMatched = true;
                secondCard.IsMatched = true;
                pairsFound++;

                // Check for game completion
                if (pairsFound == totalPairs)
                {
                    gameTimer.Stop();
                    currentGameScore = new HighScore
                    {
                        Pairs = totalPairs,
                        Attempts = attempts,
                        TimeTaken = gameTimer.Elapsed,
                        Date = DateTime.Now,
                        Difficulty = totalPairs == 8 ? "Easy" :
                                   (totalPairs == 12 ? "Medium" : "Hard")
                    };

                    var scoreForm = new HighScoreForm(currentGameScore);
                    if (scoreForm.ShowDialog() == DialogResult.OK)
                    {
                        currentGameScore.PlayerName = scoreForm.PlayerName;
                        var scores = HighScore.LoadScores();
                        scores.Add(currentGameScore);
                        HighScore.SaveScores(scores);

                        // Show confirmation and reset game
                        MessageBox.Show("Score saved!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    InitializeGame(); // Reset game regardless of saving
                }

                firstCard = secondCard = null;
                UpdateStatusLabel();
            }
            else
            {
                // No match - flip back after delay
                Timer timer = new Timer { Interval = 1000 };
                timer.Tick += (s, ev) =>
                {
                    firstCard.Flip();
                    secondCard.Flip();
                    firstCard = secondCard = null;
                    timer.Stop();
                };
                timer.Start();
            }
        }


        private void MemoryGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pairsFound < totalPairs)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit Game",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Return to main menu without closing the application
            this.DialogResult = DialogResult.OK; // Indicates we want to return to menu
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ShowHighScoreDialog()
        {
            using (var form = new HighScoreForm(currentGameScore))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    currentGameScore.PlayerName = form.PlayerName;
                    var scores = HighScore.LoadScores();
                    scores.Add(currentGameScore);
                    HighScore.SaveScores(scores);
                }
            }
        }




    }
}