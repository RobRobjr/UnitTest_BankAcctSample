using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_BankAcctSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_BankAcctSample.Tests
{
    [TestClass]//Parenthesis are optional
    public class AccountTests
    {
        [TestMethod()]
        public void Withdraw_ValidAmount_FromBalance()
        {
            //AAA testing pattern (Arrange, Act, Assert)
            //Arrange-Gets all the values (variables)
            Account account = new Account("Rob85430");//need a parameter here because of the constructor
            double startingBalance = 100;
            double withdrawAmount = 10;
            double expected = startingBalance - withdrawAmount;
            account.Deposit(startingBalance);

            //Act-calls the method your testing
            account.Withdraw(withdrawAmount);

            //Assert will check the expected outcome
            Assert.AreEqual(expected, account.Balance);
        }
    }
}