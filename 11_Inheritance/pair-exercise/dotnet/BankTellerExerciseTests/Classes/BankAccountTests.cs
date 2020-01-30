using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;
using BankTellerExercise;

namespace BankTellerExerciseTests.Classes.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]

        public void myDepositTest()
        {
            BankAccount bankAccount = new BankAccount();

            //action
            decimal result = bankAccount.Deposit(100M);

            //assert
            Assert.AreEqual(100M, result);

        }
        [TestMethod()]
        public void myWithdrawlTest()
        {
            BankAccount bankAccount = new BankAccount();

            decimal result = bankAccount.Withdraw(50M);

            Assert.AreEqual(-50M, result);
        }
        [TestMethod()]
        public void myTransferTest()
        {
            BankAccount bankAccount = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();
            //BankAccount checkingAccount = new CheckingAccount();
            //BankAccount savingsAccount = new SavingsAccount();

            bankAccount.Deposit(100M);
            bankAccount.Transfer(bankAccount2, 50M);
            Assert.AreEqual(50M, bankAccount.Balance);
            Assert.AreEqual(50M, bankAccount2.Balance);


        }


    }
}
