using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class BankAccount
    {
        #region Overview Encapsulation
        private decimal balance;
        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }
        #endregion
    }
}
