using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise5
{
    public class Counter
    {

        private int _value;

        public Counter(int startValue)
        {
            _value = startValue;
        }
        public Counter()
        {
            _value = 0;
        }

        public int value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void Increase()
        {
            _value++;
        }
        public void Decrease()
        {
            _value--;
        }
        public void Increase(int increaseBy)
        {
            if (increaseBy > 0)
            {
                _value += increaseBy;
            }
        }
        public void Decrease(int decreaseBy)
        {
            if (decreaseBy > 0)
            {
                _value -= decreaseBy;
            }
        }
    }
}
