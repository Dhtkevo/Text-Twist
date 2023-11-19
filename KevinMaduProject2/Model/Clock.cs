namespace KevinMaduProject2.Model
{
    /// <summary>
    /// Represents a game clock
    /// </summary>
    public class Clock
    {
        private int _time;
        /// <summary>
        /// Gets the time in seconds.
        /// </summary>
        /// <value>
        /// The time in seconds.
        /// </value>
        public int TimeInSeconds
        { 
            get { return _time; }
        }

        /// <summary>
        /// Gets or sets the time limit.
        /// </summary>
        /// <value>
        /// The time limit.
        /// </value>
        public int TimeLimit { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Clock"/> class.
        /// </summary>
        public Clock() : this(60)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Clock"/> class.
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        /// <exception cref="System.ArgumentException">Invalid time</exception>
        public Clock(int seconds)
        {
            if (seconds != 60 && seconds != 120 && seconds != 180)
            {
                throw new ArgumentException("Invalid time");
            }

            _time = seconds;
            TimeLimit = seconds;
        }

        /// <summary>
        /// Decrements the clock.
        /// </summary>
        public void DecrementClock()
        {
            _time--;
        }

        /// <summary>
        /// Checks the out of time.
        /// </summary>
        /// <returns></returns>
        public bool CheckOutOfTime()
        {
            return TimeInSeconds == 0;
        }


    }
}
