using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;
using BankTellerExercise;

namespace BankTellerExerciseTests.Classes.Tests
{
    [TestClass]
    public class SavingsAccountTests
    {
        [TestMethod()]

        public void mySavingsAccountTest()
        {
            BankAccount savingsAccountT = new SavingsAccount();

            decimal result = savingsAccountT.Withdraw(50M);

            Assert.AreEqual(0, result);
            
            

           
        }
        [TestMethod]
        public void mySavingsAccountTest2()
        {
            BankAccount mySavingsAccountT2 = new SavingsAccount();

            mySavingsAccountT2.Deposit(100M);

            decimal result = mySavingsAccountT2.Withdraw(50M);

            Assert.AreEqual(48, result);

        }

        [TestMethod]
        public void mySavingsAccountTest3()
        {
            BankAccount mySavingsAccountT3 = new SavingsAccount();

            mySavingsAccountT3.Deposit(200M);

            decimal result = mySavingsAccountT3.Withdraw(50M);

            Assert.AreEqual(150, result);

        }
    }
}
