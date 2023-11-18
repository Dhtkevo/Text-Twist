using KevinMaduProject2.Model.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinMaduProject2.Model
{
    public class Round
    {
        private int _score;

        public int Score
        {
            get
            {
                return _score;
            }
        }

        public Clock Clock { get; set; }

        public List<ValidWord>ValidWords { get; }

        public List<InvalidWord> InvalidWords { get; }

        public Round()
        {
            _score = 0;
            ValidWords = new List<ValidWord>();
            InvalidWords = new List<InvalidWord>();
            Clock = new Clock();
        }

        public int DetermineWordScore(string wordToBeScored)
        {

            var pointsToAdd = 0;
            // Determine amount of points word is worth
            if (wordToBeScored.Length == 3)
            {
                pointsToAdd = 90;
            }
            else if (wordToBeScored.Length == 4)
            {
                pointsToAdd = 160;

            }
            else if (wordToBeScored.Length == 5)
            {
                pointsToAdd = 250;

            }
            else if (wordToBeScored.Length == 6)
            {
                pointsToAdd = 360;

            }
            else
            {
                pointsToAdd = 490;
            }

            return pointsToAdd;
        }

        public void AddToScore(int points)
        {
            _score += points;
        }

        public void AddToValidWords(string word, int time)
        {
            var points = DetermineWordScore(word);
            var valid = new ValidWord(word, time, points);
            ValidWords.Add(valid);
        }

        public void AddToInvalidWords(string word, int time, string reason)
        {
            var invalid = new InvalidWord(word, time, reason);
            InvalidWords.Add(invalid);
        }

        public bool CheckDuplicatedWord(string wordToBeChecked)
        {
            foreach (ValidWord word in ValidWords)
            {
                if (word.Text == wordToBeChecked)
                {
                    return true;
                }
            }
            
            return false;
        }

    }
}
