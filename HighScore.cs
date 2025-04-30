using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace MemoryCardGame
{
    public class HighScore
    {
        public string Difficulty { get; set; } // Add this property
        public string PlayerName { get; set; }
        public int Pairs { get; set; }
        public int Attempts { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeTaken { get; set; }

        public int Score
        {
            get
            {
                // Calculate score: higher is better
                return (Pairs * 1000) - (Attempts * 10) - (int)TimeTaken.TotalSeconds;
            }
        }

        public static List<HighScore> LoadScores()
        {
            string path = "highscores.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<List<HighScore>>(json) ?? new List<HighScore>();
            }
            return new List<HighScore>();
        }

        public static void SaveScores(List<HighScore> scores)
        {
            // Keep only top 10 scores
            var topScores = scores
                .OrderByDescending(s => s.Score)
                .Take(10)
                .ToList();

            string json = JsonConvert.SerializeObject(topScores, Formatting.Indented);
            File.WriteAllText("highscores.json", json);
        }
    }
}