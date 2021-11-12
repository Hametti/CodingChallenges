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
    public class FindMaxTests
    {
        [TestMethod]
        public void FindSecondMaxNumber_Five_Elements_Array_Returns_Four()
        {
            var result = FindMax.FindSecondMaxNumber(new int[] { 3, 2, 1, 5, 4 });

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void FindSecondMaxNumber_Eight_Elements_Array_Returns_TwoHundredThirteen()
        {
            var result = FindMax.FindSecondMaxNumber(new int[] { -99, -125, 54, 33, 213, -22, 28, 1024 });

            Assert.AreEqual(213, result);
        }
    }
}
