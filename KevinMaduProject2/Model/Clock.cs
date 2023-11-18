using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinMaduProject2.Model
{
    public class Clock
    {
        private int _time;
        public int TimeInSeconds
        { 
            get { return _time; }
        }

        public int TimeLimit { get; set; }

        public Clock() : this(60)
        {
        }

        public Clock(int seconds)
        {
            if (seconds != 60 && seconds != 120 && seconds != 180)
            {
                throw new ArgumentException("Invalid time");
            }

            _time = seconds;
            TimeLimit = seconds;
        }

        public void DecrementClock()
        {
            _time--;
        }

        public bool CheckOutOfTime()
        {
            return TimeInSeconds == 0;
        }


    }
}
