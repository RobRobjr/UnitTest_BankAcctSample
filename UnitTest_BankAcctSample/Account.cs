using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_BankAcctSample
{
    /// <summary>
    /// Represents a simple checking account at a bank
    /// </summary>
    public class Account
    {
        public Account(string AccountNum)
        {
            AccountNumber = AccountNum;
        }

        public string AccountNumber { get; private set; }

        public string Name { get; set; }

        public double Balance { get; private set; }

        /// <summary>
        /// Withdraws a specified positive amount from this bank account
        /// </summary>
        /// <param name="amount">The amount to withdraw</param>
        /// <exception cref="ArgumentException">Negative amounts will throw exception</exception>
        /// <returns>Returns the new balance</returns>
        public double Withdraw(double amount)
        {
            //Ensure there is money to be withdrawn
            if (amount <= 0)
            {
                throw new ArgumentException($"{nameof(amount)} must be positive!");
            }
         
            //TODO: Add a limit to withdraw
            //TODO: Ensure the amount is positive
            Balance -= amount;
            return Balance;
        }

        /// <summary>
        /// Deposits a specified amount from this bank account
        /// </summary>
        /// <param name="amount">The amount being deposited</param>
        /// <returns>Current balance</returns>
        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }
    }
}
