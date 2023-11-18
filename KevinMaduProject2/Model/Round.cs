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

        public List<ValidWord>ValidWords { get; }
        public List<InvalidWord> InvalidWords { get; }

        public Round()
        {
            _score = 0;
            ValidWords = new List<ValidWord>();
            InvalidWords = new List<InvalidWord>();
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

            AddToScore(pointsToAdd);

            return pointsToAdd;
        }

        private void AddToScore(int points)
        {
            _score += points;
        }

    }
}
