using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinMaduProject2.Model.Word
{
    public class Word
    {
        public string Text { get; }

        public int GameTime { get; }

        public Word(string text, int time)
        {
            if (string.IsNullOrWhiteSpace(text)) throw new ArgumentException(nameof(text));
            if (text.Length < 3) throw new ArgumentException("Word must be atleast 3 characters long");
            if (time < 0) throw new ArgumentException("Time is not valid");

            Text = text;
            GameTime = time;
        }

    }
}
