namespace KevinMaduProject2.Model.Word
{
    /// <summary>
    /// Represents a valid word
    /// </summary>
    /// <seealso cref="KevinMaduProject2.Model.Word.Word" />
    public class ValidWord : Word
    {
        /// <summary>
        /// Gets the points earned.
        /// </summary>
        /// <value>
        /// The points earned.
        /// </value>
        public int PointsEarned { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidWord"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="time">The time.</param>
        /// <param name="points">The points.</param>
        /// <exception cref="System.ArgumentException">Must enter valid range of points</exception>
        public ValidWord(string text, int time, int points ) : base(text, time)
        {
            if (points < 0) throw new ArgumentException("Must enter valid range of points");

            PointsEarned = points;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return base.ToString() + $" Points: {PointsEarned}";
        }
    }
}
