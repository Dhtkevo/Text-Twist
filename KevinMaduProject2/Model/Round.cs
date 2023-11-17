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
        public List<ValidWord> validWords { get; }
        public List<InvalidWord> invalidWords { get; }

        public Round()
        {
            validWords = new List<ValidWord>();
            invalidWords = new List<InvalidWord>();
        }

    }
}
