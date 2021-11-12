using CodingChallenges.Data.NumbersAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Tests.NumbersAlgorithms
{
    [TestClass]
    public class PrimeNumberTests
    {
        [TestMethod]
        public void PrimeNumber_NegativeNumber_ReturnsFalse()
        {
            var result = PrimeNumber.IsPrimeNumber(-5);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void PrimeNumber_Zero_ReturnsFalse()
        {
            var result = PrimeNumber.IsPrimeNumber(0);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void PrimeNumber_One_ReturnsFalse()
        {
            var result = PrimeNumber.IsPrimeNumber(1);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void PrimeNumber_Two_ReturnsTrue()
        {
            var result = PrimeNumber.IsPrimeNumber(2);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void PrimeNumber_Thirteen_ReturnsTrue()
        {
            var result = PrimeNumber.IsPrimeNumber(13);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void PrimeNumber_HighNumber_ReturnsTrue()
        {
            var result = PrimeNumber.IsPrimeNumber(104729);

            Assert.AreEqual(true, result);
        }
    }
}
