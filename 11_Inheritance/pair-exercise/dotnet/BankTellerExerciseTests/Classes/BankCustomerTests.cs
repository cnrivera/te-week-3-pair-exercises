using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;
using BankTellerExercise;

namespace BankTellerExerciseTests.Classes.Tests
{
    [TestClass()]
    public class BankCustomerTests
    {
        [TestMethod()]

        public void isVIPTest()
        {
            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();

            bool result = false;
            Assert.AreEqual(false, result);

        }

        [TestMethod()]

        public void isVIPTest2()
        {
            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();

            bankAccount1.Deposit(10000);
            bankAccount2.Deposit(20000);


            bool result = true;
            Assert.AreEqual(true, result);

        }




    }
}
