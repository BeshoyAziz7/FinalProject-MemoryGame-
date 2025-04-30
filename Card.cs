using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace MemoryCardGame
{
    public class Card : Button
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public bool IsFlipped { get; set; }
        public bool IsMatched { get; set; }

        // Image for the back of the card
        public static Image BackImage { get; set; }

        // Image for the front of the card (will be set based on Value)
        public Image FrontImage { get; set; }

        // Default constructor (maintain for compatibility)
        public Card() : this(8) // Default to easy difficulty (8 pairs)
        {
        }

        // New constructor with difficulty parameter
        public Card(int difficulty)
        {
            // Adjust size based on difficulty
            int size = CalculateCardSize(difficulty);
            Size = new Size(size, size);
            Margin = new Padding(5);
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private int CalculateCardSize(int difficulty)
        {
            switch (difficulty)
            {
                case 16: // Hard - more cards need to be smaller
                    return 80;
                case 12: // Medium
                    return 90;
                case 8:  // Easy
                default:
                    return 100;
            }
        }

        public void Flip()
        {
            if (IsMatched) return;

            IsFlipped = !IsFlipped;
            BackgroundImage = IsFlipped ? FrontImage : BackImage;
        }
    }
}