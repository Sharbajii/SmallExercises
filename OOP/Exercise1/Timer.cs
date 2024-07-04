using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise1
{
    public class Timer
    {

        private int _seconds;
        private int _handredthsSeconds;

        public Timer()
        {
            _seconds = 0;
            _handredthsSeconds = 0;
        }
        public void Advance()
        {
            _handredthsSeconds++;
            if (_handredthsSeconds == 100)
            {
                _handredthsSeconds = 0;
                _seconds++;

                if (_seconds == 60)
                {
                    _seconds = 0;
                }
            }
        }


        public override string ToString()
        {
            return $"{_seconds:00}:{_handredthsSeconds:00}";
        }
    }
}
