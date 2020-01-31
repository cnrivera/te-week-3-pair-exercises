using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;
using Exercises.Classes;

namespace Exercises.Test
{
    [TestClass]
    public class NumbersToWordsTests
    {
        [TestMethod()]


        public void ConvertOneDigit()
        {
            NumbersToWords numbersToWords = new NumbersToWords();
            String result = numbersToWords.Convert(5);
            Assert.AreEqual("five", result);

        }



    }
}
