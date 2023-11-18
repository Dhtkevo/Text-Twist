using KevinMaduProject2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinMaduProject2.Utilities
{
    public class ScoreTimeDescendingOrder : IComparer<Round>
    {
        public int Compare(Round one, Round two)
        {
  
            if (one.Score == two.Score)
            {
                if (one.Clock.TimeLimit < two.Clock.TimeLimit)
                {
                    return -1;
                } else if (one.Clock.TimeLimit > two.Clock.TimeLimit)
                {
                    return 1;
                } else
                {
                    return 0;
                }
            }

            return one.CompareTo(two);
        }
    }
}
