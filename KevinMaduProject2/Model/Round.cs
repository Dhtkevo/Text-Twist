using KevinMaduProject2.Model.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinMaduProject2.Model
{
    public class Round : IComparable<Round>
    {
        public List<char> Letters { get; }

        public List<char> RandomLetters { get; }

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

            Letters = new List<char>();
            RandomLetters = new List<char>();
            ValidWords = new List<ValidWord>();
            InvalidWords = new List<InvalidWord>();
            Clock = new Clock();

            PopulateLetters();
            GenerateSevenRandomLetters();
        }

        public void GenerateSevenRandomLetters()
        {
            Random rnd = new Random();

            for (int j = 0; j < 7; j++)
            {
                var index = rnd.Next(97);
                var letter = Letters[index];
                RandomLetters.Add(letter);

            }
        }
        public void Twist()
        {

            List<char> odds = new List<char>();
            List<char> evens = new List<char>();

            for (var i = 0; i < RandomLetters.Count; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(RandomLetters[i]);
                }
                else
                {
                    evens.Add(RandomLetters[i]);
                }
            }

            RandomLetters.Clear();

            RandomLetters.Add(evens[3]);

            for (var i = 0; i < 3; i++)
            {
                RandomLetters.Add(evens[i]);
                RandomLetters.Add(odds[i]);
            }
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

        private void PopulateLetters()
        {
            // add 11 e's to letters
            for (var i = 0; i < 11; i++)
            {
                Letters.Add('e');
            }

            // add 9 t's
            for (var i = 0; i < 9; i++)
            {
                Letters.Add('t');
            }

            // add 8 o's
            for (var i = 0; i < 8; i++)
            {
                Letters.Add('o');
            }

            // add 6 a,i,n,s
            for (var i = 0; i < 6; i++)
            {
                Letters.Add('a');
                Letters.Add('i');
                Letters.Add('n');
                Letters.Add('s');
            }

            // add 5 h,r
            for (var i = 0; i < 5; i++)
            {
                Letters.Add('h');
                Letters.Add('r');
            }

            // add 4 l's
            for (var i = 0; i < 4; i++)
            {
                Letters.Add('l');
            }

            // add 3 d,u,w,y
            for (var i = 0; i < 3; i++)
            {
                Letters.Add('d');
                Letters.Add('u');
                Letters.Add('w');
                Letters.Add('y');
            }

            // add 2 b,c,f,g,m,p,v
            for (var i = 0; i < 2; i++)
            {
                Letters.Add('b');
                Letters.Add('c');
                Letters.Add('f');
                Letters.Add('g');
                Letters.Add('m');
                Letters.Add('p');
                Letters.Add('v');
            }

            // add 1 j,k,q,x,z
            for (var i = 0; i < 1; i++)
            {
                Letters.Add('j');
                Letters.Add('k');
                Letters.Add('q');
                Letters.Add('x');
                Letters.Add('z');
            }
        }

        public override string ToString()
        {
            return $"Score: {Score} - Time Remaining: {Clock.TimeInSeconds} seconds";
        }

        public int CompareTo(Round otherRound)
        {
            if (Score > otherRound.Score)
            {
                return -1;

            } else if (Score < otherRound.Score)
            {
                return 1;

            } else
            {
                return 0;

            }
        }
    }
}
