using KevinMaduProject2.Model;

namespace KevinMaduProject2.Utilities
{
    /// <summary>
    /// Sorts rounds by score and time
    /// </summary>
    /// <seealso cref="System.Collections.Generic.IComparer&lt;KevinMaduProject2.Model.Round&gt;" />
    public class ScoreTimeDescendingOrder : IComparer<Round>
    {
        /// <summary>
        /// Compares the specified one.
        /// </summary>
        /// <param name="one">The one.</param>
        /// <param name="two">The two.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">null round</exception>
        public int Compare(Round one, Round two)
        {
            if (one == null) throw new ArgumentException("null round");
            if (two == null) throw new ArgumentException("null round");


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
