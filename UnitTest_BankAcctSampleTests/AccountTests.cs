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
        private Account acc;

        [TestInitialize]//Run's this before every single test
        public void TestInit()
        {
            acc = new Account("Rob");
            acc.Deposit(100);
        }

        [TestMethod]
        public void Withdraw_ValidAmount_FromBalance()
        {
            //AAA testing pattern (Arrange, Act, Assert)
            //Arrange-Gets all the values (variables) 
            double startingBalance = acc.Balance;
            double withdrawAmount = 10;
            double expected = startingBalance - withdrawAmount;
            
            //Act-calls the method your testing
            acc.Withdraw(withdrawAmount);

            //Assert will check the expected outcome (checks the values)
            Assert.AreEqual(expected, acc.Balance);
        }

        [TestMethod]
        public void Withdraw_NegativeAmount_ThrowsArgumentException()
        {
            //Arrange
            double withdrawAmount = -5;
            //Assert => Act
            Assert.ThrowsException<ArgumentException> (() => acc.Withdraw(withdrawAmount));//Empty () here because we aren't using a parameter to run the function
        }
    }
}