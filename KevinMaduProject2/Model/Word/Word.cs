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

        public DateTime GameTime { get; }

        public Word(string text, DateTime time)
        {
            if (string.IsNullOrWhiteSpace(text)) throw new ArgumentException(nameof(text));
            if (text.Length < 3) throw new ArgumentException("Word must be atleast 3 characters long");

            Text = text;
            GameTime = time;
        }

    }
}
