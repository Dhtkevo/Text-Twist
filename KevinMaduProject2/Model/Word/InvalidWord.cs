namespace KevinMaduProject2.Model.Word
{
    /// <summary>
    /// Represents an invalid word
    /// </summary>
    /// <seealso cref="KevinMaduProject2.Model.Word.Word" />
    public class InvalidWord : Word
    {
        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        public string Reason { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidWord"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="time">The time.</param>
        /// <param name="reason">The reason.</param>
        /// <exception cref="System.ArgumentException">Must give reason why word is invalid</exception>
        public InvalidWord(string text, int time, string reason) : base(text, time)
        {
            if (string.IsNullOrWhiteSpace(reason)) throw new ArgumentException("Must give reason why word is invalid");

            Reason = reason;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return base.ToString() + $" Reason: {Reason}";
        }
    }
}
