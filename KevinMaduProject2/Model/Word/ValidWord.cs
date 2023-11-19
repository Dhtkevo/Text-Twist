using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinMaduProject2.Model.Word
{
    public class ValidWord : Word
    {
        public int PointsEarned { get; }

        public ValidWord(string text, int time, int points ) : base(text, time)
        {
            if (points < 0) throw new ArgumentException("Must enter valid range of points");

            PointsEarned = points;
        }

        public override string ToString()
        {
            return base.ToString() + $" Points: {PointsEarned}";
        }
    }
}
