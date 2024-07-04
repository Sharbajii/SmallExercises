using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise14
{
    public class SimpleDate
    {
        private int _year;
        private int _month;
        private int _day;


        public SimpleDate(int day , int month, int year)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public void Advance()
        {
            _day++;

            if (_day > 30)
            {
                _day = 1;
                _month++;

                if (_month > 12)
                {
                    _month = 1;
                    _year++;
                }
            }
        }

        public void Advance( int howManyDays)
        {
            for(int i = 0; i < howManyDays; i++)
            {
                Advance();
            }
        }

        public SimpleDate AfterNumberOfDays(int days)
        {
            SimpleDate newDate = new SimpleDate(_day, _month,_year );

            for (int i = 0; i < days; i++)
            {
                newDate.Advance();
            }

            return newDate;
        }
        
        public override string ToString()
        {
            return _day + "." + _month + "." +_year;
        }

     
    }
}

