namespace KevinMaduProject2.Model.Word
{
    /// <summary>
    /// Represents a word
    /// </summary>
    public abstract class Word
    {
        /// <summary>
        /// Gets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; }

        /// <summary>
        /// Gets the game time.
        /// </summary>
        /// <value>
        /// The game time.
        /// </value>
        public int GameTime { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Word"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="time">The time.</param>
        /// <exception cref="System.ArgumentException">
        /// text
        /// or
        /// Word must be atleast 3 characters long
        /// or
        /// Time is not valid
        /// </exception>
        public Word(string text, int time)
        {
            if (string.IsNullOrWhiteSpace(text)) throw new ArgumentException(nameof(text));
            if (text.Length < 3) throw new ArgumentException("Word must be atleast 3 characters long");
            if (time < 0) throw new ArgumentException("Time is not valid");

            Text = text;
            GameTime = time;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public new virtual string ToString()
        {
            return $"Text: {Text} Time: {GameTime}";
        }

    }
}
