using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;
using Exercises.Classes;

namespace Exercises.Test
{
    [TestClass]

    public class StringCalculatorTests
    {
        [TestMethod()]
        public void AddZero()
        {
            StringCalculator strcalculator = new StringCalculator();
            int result = strcalculator.Add("");
            Assert.AreEqual(0, result);

        }
        [TestMethod()]
        public void AddOneNum()
        {
            StringCalculator strcalculator = new StringCalculator();
            int result = strcalculator.Add("1");
            Assert.AreEqual(1, result);

            result = strcalculator.Add("5");
            Assert.AreEqual(5, result);

            result = strcalculator.Add("20");
            Assert.AreEqual(20, result);

            result = strcalculator.Add("100");
            Assert.AreEqual(100, result);

        }
        [TestMethod()]
        public void AddMultipleNumbers()
        {
            StringCalculator strcalculator = new StringCalculator();
            int result = strcalculator.Add("1,2");
            Assert.AreEqual(3, result);

            result = strcalculator.Add("10,20");
            Assert.AreEqual(30, result);

            result = strcalculator.Add("1, 2, 3");
            Assert.AreEqual(6, result);

        }
        [TestMethod()]
        public void AddNewLine()
        {
            StringCalculator strcalculator = new StringCalculator();
            int result = strcalculator.Add("1\n2");
            Assert.AreEqual(3, result);

            result = strcalculator.Add("1\n2\n3");
            Assert.AreEqual(6, result);

            result = strcalculator.Add("1\n2\n5,5");
            Assert.AreEqual(13, result);
        }

    }
}
