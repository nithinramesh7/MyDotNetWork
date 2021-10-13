using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConceptArchitect.Finance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptArchitect.Finance.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        BankAccount obj1 = new BankAccount(001, "Nith", "Pwd", 25000, 4);

        [TestMethod()]
        public void DepositTest()
        {
            var actual = obj1.Deposit(20000);
            int expected = 45000;

            Assert.AreEqual(expected, obj1.Balance);
        }

        [TestMethod()]
        public void WithdrawTestCorrectPassword()
        {

            var actual = obj1.Withdraw(5000, "Pwd");

            int expected = 20000;

            Assert.AreEqual(expected, obj1.Balance);
        }


        [TestMethod()]
        public void WithdrawTestWrongPassword()
        {

            var actual = obj1.Withdraw(5000, "PAS11");

            bool expected = false;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CreditInterestTest()
        {

            int expected = 25000 + (25000 * 4 / 1200);
            obj1.CreditInterest();
            Assert.AreEqual(expected, obj1.Balance);

        }


    }
}