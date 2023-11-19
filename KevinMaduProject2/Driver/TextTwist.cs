using KevinMaduProject2.Model;
using KevinMaduProject2.Utilities;

namespace KevinMaduProject2.Driver
{
    /// <summary>
    /// Driver for TextTwist game
    /// </summary>
    public class TextTwist
    {

        /// <summary>
        /// Gets all rounds.
        /// </summary>
        /// <value>
        /// All rounds.
        /// </value>
        public List<Round> AllRounds { get; }

        /// <summary>
        /// Gets or sets the round.
        /// </summary>
        /// <value>
        /// The round.
        /// </value>
        public Round Round { get; set; }

        private List<Dictionary> _dictionaries;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTwist"/> class.
        /// </summary>
        public TextTwist()
        {
            _dictionaries = new DataImporter().ReadFile();
            AllRounds = new List<Round>();
            Round = new Round();  
        }

        /// <summary>
        /// Checks the word is valid.
        /// </summary>
        /// <param name="userWord">The user word.</param>
        /// <returns></returns>
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


        /// <summary>
        /// Creates the new round.
        /// </summary>
        public void CreateNewRound()
        {
            Round = new Round();
        }

        /// <summary>
        /// Saves the round history.
        /// </summary>
        public void SaveRoundHistory()
        {
            AllRounds.Add(Round);
        }

        
    }
}
