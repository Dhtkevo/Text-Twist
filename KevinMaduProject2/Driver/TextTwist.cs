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
        
        public List<Round> AllRounds { get; }

        public Round Round { get; set; }

        private List<Dictionary> _dictionaries;


        public TextTwist()
        {
            _dictionaries = new DataImporter().ReadFile();
            AllRounds = new List<Round>();
            Round = new Round();  
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

   

        public void CreateNewRound()
        {
            Round = new Round();
        }

        public void SaveRoundHistory()
        {
            AllRounds.Add(Round);
        }

        
    }
}
