using CodingChallenges.Data.StringChallenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Tests.StringChallengesTests
{
    [TestClass]
    public class RemoveDuplicatesTests
    {
        [TestMethod]
        public void RemoveDuplicatesFromString_HelloWorld_ReturnsStringWithoutDuplicates()
        {
            var str = "Hello world";

            var result = RemoveDuplicates.RemoveDuplicatesFromString(str);

            Assert.AreEqual("Helo wrd", result);
        }

        [TestMethod]
        public void RemoveDuplicatesFromString_EmptyString_ReturnsStringWithoutDuplicates()
        {
            var str = "";

            var result = RemoveDuplicates.RemoveDuplicatesFromString(str);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void RemoveDuplicatesFromString_SampleString_ReturnsStringWithoutDuplicates()
        {
            var str = "SampleString";

            var result = RemoveDuplicates.RemoveDuplicatesFromString(str);

            Assert.AreEqual("Sampletring", result);
        }
    }
}
