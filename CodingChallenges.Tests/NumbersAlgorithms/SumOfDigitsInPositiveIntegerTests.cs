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
    public class SumOfDigitsInPositiveIntegerTests
    {
        [TestMethod]
        public void SumOfDigitsInPositiveInteger_1111_Returns4()
        {
            var result = SumOfDigitsInPositiveInteger.FindSumOfDigits(1111);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SumOfDigitsInPositiveInteger_Minus1111_Returns0()
        {
            var result = SumOfDigitsInPositiveInteger.FindSumOfDigits(-1111);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SumOfDigitsInPositiveInteger_5_Returns1()
        {
            var result = SumOfDigitsInPositiveInteger.FindSumOfDigits(5);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SumOfDigitsInPositiveIntegerDifferentApproach_1111_Returns4()
        {
            var result = SumOfDigitsInPositiveInteger.FindSumOfDigitsDifferentApproach(1111);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SumOfDigitsInPositiveIntegerDifferentApproach_Minus1111_Returns4()
        {
            var result = SumOfDigitsInPositiveInteger.FindSumOfDigitsDifferentApproach(-1111);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SumOfDigitsInPositiveIntegerDifferentApproach_5_Returns4()
        {
            var result = SumOfDigitsInPositiveInteger.FindSumOfDigitsDifferentApproach(5);

            Assert.AreEqual(5, result);
        }
    }
}
