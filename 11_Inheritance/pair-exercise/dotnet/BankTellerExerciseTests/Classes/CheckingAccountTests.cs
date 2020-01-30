using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;
using BankTellerExercise;

namespace BankTellerExerciseTests.Classes.Tests

{
    [TestClass]
    public class CheckingAccountTests
    {

        [TestMethod()]

        public void myWithdrawlChTest()
        {
            BankAccount checkingAccountT = new CheckingAccount();

            decimal result = checkingAccountT.Withdraw(50M);
            Assert.AreEqual(-60, result);


            decimal result2 = checkingAccountT.Withdraw(150M);
            Assert.AreEqual(-60, result2);



        }

        [TestMethod]
        public void myCheckingAccountTest2()
        {
            BankAccount myCheckingAccountT2 = new SavingsAccount();

            myCheckingAccountT2.Deposit(200M);

            decimal result = myCheckingAccountT2.Withdraw(50M);

            Assert.AreEqual(150, result);

        }
    }
}
