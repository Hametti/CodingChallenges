using CodingChallenges.Data.ArrayChallenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Tests.ArrayChallenges
{
    [TestClass]
    public class ConvertingTests
    {
        [TestMethod]
        public void ConvertTwoDimensionalToOneDimensional_123_456_Returns123456()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
            var result = Converting.ConvertTwoDimensionalToOneDimensional(array, 2, 3);

            var resultString = "";

            foreach (int number in result)
                resultString += number;

            Assert.AreEqual("123456", resultString);
        }
    }
}
