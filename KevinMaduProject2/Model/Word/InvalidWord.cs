using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinMaduProject2.Model.Word
{
    public class InvalidWord : Word
    {
        public string Reason { get; set; }

        public InvalidWord(string text, int time, string reason) : base(text, time)
        {
            if (string.IsNullOrWhiteSpace(reason)) throw new ArgumentException("Must give reason why word is invalid");

            Reason = reason;
        }
    }
}
