using OOP.Exercise7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise8
{
    public class PaymentTerminal
    {
        private double _money;  // amount of cash
        private int _coffeeAmount; // number of sold coffees
        private int _lunchAmount;  // number of sold lunches

        public PaymentTerminal()
        {
            _money = 1000;
            _coffeeAmount = 0;
            _lunchAmount = 0;
        }

        public double DrinkCoffee(double payment)
        {
            double coffee = 2.50;

            if (payment >= coffee)
            {
                _money += coffee;
                _coffeeAmount++;
                return payment - coffee;
            }
            else
            {
                return payment;
            }
        }

        public double EatLunch(double payment)
        {
            double lunch = 10.30;

            if (payment >= lunch)
            {
                _money += lunch;
                _lunchAmount++;
                return payment - lunch;
            }
            else
            {
                return payment;
            }
        }
        public bool DrinkCoffee(PaymentCard card)
        {

            if (card.balance >= 2.50)
            {
                _coffeeAmount++;
                card.balance -= 2.50;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EatLunch(PaymentCard card)
        {
            double lunch = 10.30;
            if (card.balance >= lunch)
            {
                card.balance -= lunch;
                _lunchAmount++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddMoneyToCard(PaymentCard card, double sum)
        {

            if (sum > 0)
            {
                card.AddMoney(sum);
                _money += sum;
            }
        }

        public override string ToString()
        {
            return "money: " + _money + ", number of sold coffees: " + _coffeeAmount + ", number of sold lunches: " + _lunchAmount;
        }

    }
}
