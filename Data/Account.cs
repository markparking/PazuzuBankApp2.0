using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazuzuBankApp.Data
{
    public class Account
    {
        public string AccountNumber { get; }
        public decimal Balance { get; private set; }

        public Account(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || Balance < amount)
            {
                return false;
            }

            Balance -= amount;
            return true;
        }
    }
}
