using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise15
{
    public class Money
    {
        private int _euros;
        private int _cents;

        public  Money(int euros, int cents)
        {
            if (cents > 99)
            {
                euros += cents/100;
                cents%=100;
            }

            _euros = euros;
            _cents = cents;
        }

        public Money Plus(Money addition)
        {
            int totalEuros = _euros + addition._euros;
            int totalCents= _cents + addition._cents;

            if(totalCents >=100)
            {
                totalEuros += totalCents / 100;
                totalCents%=100;
            }
            Money newMoney=new Money(totalEuros,totalCents);
            return newMoney;
        }

        public Money Minus(Money minition)
        {
            int totalEuros=_euros-minition._euros;
            int totalcents= _cents-minition._cents;

            if (totalcents < 0)
            {
                totalEuros -= 1;
                totalcents +=100 ;
            }
            if(totalEuros<0)
            {
                totalEuros = 0;
                totalcents = 0;
            }
            

            Money newMoney = new Money(totalEuros,totalcents);
            return newMoney;
        }

        public bool LessThan(Money compared)
        {
            if (_euros > compared._euros)
            {
                return false;
            }
            else if (_euros == compared._euros && _cents >= compared._cents)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public string ToString()
        {
            string zero = "";
            if (_cents <= 10)
            {
                zero = "0";
            }
            return _euros + "." + zero + _cents + "e";
        }






    }
}
