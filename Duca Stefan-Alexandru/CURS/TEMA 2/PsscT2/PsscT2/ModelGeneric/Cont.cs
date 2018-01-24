using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.ModelGeneric
{
    class Cont
    {
        private float balance;

        public Cont(float balance)
        {
            this.balance = balance;
        }

        public void Deposit(float amount)
        {
            balance += amount;
        }

        public void Withdraw(float amount)
        {
            balance -= amount;
        }

        public float GetBalance()
        {
            return balance;
        }

        public Cont TransferFunds(Cont destination, float amount)
        {
            if (amount < balance && amount > 0)
            {
                destination.Deposit(amount);
                Withdraw(amount);
            }
            else throw new NotFundsException();
            return destination;
        }
    }
}
