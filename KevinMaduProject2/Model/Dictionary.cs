namespace KevinMaduProject2.Model
{
    /// <summary>
    /// Represents dictionary of valid words
    /// </summary>
    public class Dictionary
    {
        /// <summary>
        /// Gets or sets the letter.
        /// </summary>
        /// <value>
        /// The letter.
        /// </value>
        public string Letter { get; set; }

        /// <summary>
        /// Gets or sets the words.
        /// </summary>
        /// <value>
        /// The words.
        /// </value>
        public List<string> Words { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dictionary"/> class.
        /// </summary>
        /// <param name="letter">The letter.</param>
        /// <param name="words">The words.</param>
        /// <exception cref="System.ArgumentException">Letter cant be null</exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        public Dictionary(string letter, List<string> words)
        {
            if (string.IsNullOrEmpty(letter)) throw new ArgumentException("Letter cant be null");
            if (words == null) throw new ArgumentNullException();

            Letter = letter;
            Words = words;
        }


    }
}
