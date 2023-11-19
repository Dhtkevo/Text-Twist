using KevinMaduProject2.Model.Word;

namespace KevinMaduProject2.Model
{
    /// <summary>
    /// Represents a round
    /// </summary>
    /// <seealso cref="System.IComparable&lt;KevinMaduProject2.Model.Round&gt;" />
    public class Round : IComparable<Round>
    {
        /// <summary>
        /// Gets the letters.
        /// </summary>
        /// <value>
        /// The letters.
        /// </value>
        public List<char> Letters { get; }

        /// <summary>
        /// Gets the random letters.
        /// </summary>
        /// <value>
        /// The random letters.
        /// </value>
        public List<char> RandomLetters { get; }

        private int _score;

        /// <summary>
        /// Gets the score.
        /// </summary>
        /// <value>
        /// The score.
        /// </value>
        public int Score {
            get { return _score; } 
        }

        /// <summary>
        /// Gets or sets the clock.
        /// </summary>
        /// <value>
        /// The clock.
        /// </value>
        public Clock Clock { get; set; }

        /// <summary>
        /// Gets the valid words.
        /// </summary>
        /// <value>
        /// The valid words.
        /// </value>
        public List<ValidWord>ValidWords { get; }

        /// <summary>
        /// Gets the invalid words.
        /// </summary>
        /// <value>
        /// The invalid words.
        /// </value>
        public List<InvalidWord> InvalidWords { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Round"/> class.
        /// </summary>
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

        /// <summary>
        /// Generates the seven random letters.
        /// </summary>
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

        /// <summary>
        /// Twists the letters.
        /// </summary>
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

        /// <summary>
        /// Determines the word score.
        /// </summary>
        /// <param name="wordToBeScored">The word to be scored.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException"></exception>
        public int DetermineWordScore(string wordToBeScored)
        {
            if (string.IsNullOrWhiteSpace(wordToBeScored)) throw new ArgumentException();

            var pointsToAdd = 0;

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

        /// <summary>
        /// Adds to score.
        /// </summary>
        /// <param name="points">The points.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public void AddToScore(int points)
        {
            if (points < 90) throw new ArgumentException("Must be atleast 90");

            _score += points;
        }

        /// <summary>
        /// Adds to valid words.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <param name="time">The time.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public void AddToValidWords(string word, int time)
        {
            if (string.IsNullOrWhiteSpace(word)) throw new ArgumentException("Word blank");
            if (time < 0) throw new ArgumentException("Time bad");

            var points = DetermineWordScore(word);
            var valid = new ValidWord(word, time, points);
            ValidWords.Add(valid);
        }

        /// <summary>
        /// Adds to invalid words.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <param name="time">The time.</param>
        /// <param name="reason">The reason.</param>
        /// <exception cref="System.ArgumentException">
        /// Invalid reason
        /// or
        /// Invalid word
        /// or
        /// invalid time
        /// </exception>
        public void AddToInvalidWords(string word, int time, string reason)
        {
            if (string.IsNullOrEmpty(reason)) throw new ArgumentException("Invalid reason");
            if (string.IsNullOrEmpty(word)) throw new ArgumentException("Invalid word");
            if (time < 0) throw new ArgumentException("invalid time");

            var invalid = new InvalidWord(word, time, reason);
            InvalidWords.Add(invalid);
        }

        /// <summary>
        /// Checks the duplicated word.
        /// </summary>
        /// <param name="wordToBeChecked">The word to be checked.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Invalid word</exception>
        public bool CheckDuplicatedWord(string wordToBeChecked)
        {
            if (string.IsNullOrWhiteSpace(wordToBeChecked)) throw new ArgumentException("Invalid word");

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
            for (var i = 0; i < 11; i++)
            {
                Letters.Add('e');
            }

            for (var i = 0; i < 9; i++)
            {
                Letters.Add('t');
            }

            for (var i = 0; i < 8; i++)
            {
                Letters.Add('o');
            }

            for (var i = 0; i < 6; i++)
            {
                Letters.Add('a');
                Letters.Add('i');
                Letters.Add('n');
                Letters.Add('s');
            }

            for (var i = 0; i < 5; i++)
            {
                Letters.Add('h');
                Letters.Add('r');
            }

            for (var i = 0; i < 4; i++)
            {
                Letters.Add('l');
            }

            for (var i = 0; i < 3; i++)
            {
                Letters.Add('d');
                Letters.Add('u');
                Letters.Add('w');
                Letters.Add('y');
            }

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

            for (var i = 0; i < 1; i++)
            {
                Letters.Add('j');
                Letters.Add('k');
                Letters.Add('q');
                Letters.Add('x');
                Letters.Add('z');
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Score: {Score} - Time Limit: {Clock.TimeLimit} seconds";
        }

        /// <summary>
        /// Compares to.
        /// </summary>
        /// <param name="otherRound">The other round.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Round can't be null</exception>
        public int CompareTo(Round otherRound)
        {
            if (otherRound == null) throw new ArgumentException("Round can't be null");

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
