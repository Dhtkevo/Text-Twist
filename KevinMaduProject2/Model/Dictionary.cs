using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinMaduProject2.Model
{
    public class Dictionary
    {
        public string Letter { get; set; }

        public List<string> Words { get; set; }

        public Dictionary(string letter, List<string> words)
        {
            Letter = letter;
            Words = words;
        }


    }
}
