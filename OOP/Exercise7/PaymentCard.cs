using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise7
{
    public class PaymentCard
    {
        public double balance { get; set; }

        public PaymentCard(double balance)
        {
            this.balance = balance;
        }

        public void AddMoney(double increase)
        {
            this.balance = this.balance + increase;
        }

        public bool TakeMoney(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }

            return false;
        }

    }
}
