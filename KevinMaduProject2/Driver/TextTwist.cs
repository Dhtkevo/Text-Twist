using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KevinMaduProject2.Model;
using KevinMaduProject2.Utilities;

namespace KevinMaduProject2.Driver
{
    public class TextTwist
    {
        private int _score;

        public int Score
        {
            get
            {
                return _score;
            }
        }
        public List<char> Letters { get; } 

        public List<char> RandomLetters { get; }

        public List<string> UserWords { get; }

        private List<Dictionary> _dictionaries;


        public TextTwist()
        {
            _score = 0;
            Letters = new List<char>();
            RandomLetters = new List<char>();
            _dictionaries = new DataImporter().ReadFile();
            UserWords = new List<string>();

            PopulateLetters();
            GenerateSevenRandomLetters();
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

        public bool CheckWordIsValid(string userWord)
        {
            foreach (Dictionary dict in _dictionaries)
            {
                if (dict.Letter.ToLower() == userWord[0].ToString().ToLower())
                {
                    foreach (string word in dict.Words)
                    {
                        if (word == userWord.ToLower())
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
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
    }
}
