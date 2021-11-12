using CodingChallenges.Data.StringChallenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenges.Tests.StringChallengesTests
{
    [TestClass]
    public class ReverseStringTests
    {
        [TestMethod]
        public void ReverseString_Programming_ReturnsReversedString()
        {
            var testString = "programming";

            var reversedString = ReversingString.ReverseString(testString);

            Assert.AreEqual("gnimmargorp", reversedString);
        }

        [TestMethod]
        public void ReverseString_Racecar_ReturnsReversedString()
        {
            var testString = "racecar";

            var reversedString = ReversingString.ReverseString(testString);

            Assert.AreEqual("racecar", reversedString);
        }

        [TestMethod]
        public void ReverseString_Hello_World_ReturnsReversedString()
        {
            var testString = "hello world";

            var reversedString = ReversingString.ReverseString(testString);

            Assert.AreEqual("dlrow olleh", reversedString);
        }

        [TestMethod]
        public void ReverseStringByRecursion_Programming_ReturnsReversedString()
        {
            var testString = "programming";

            var reversedString = ReversingString.ReverseStringByRecursion(testString);

            Assert.AreEqual("gnimmargorp", reversedString);
        }

        [TestMethod]
        public void ReverseStringByRecursion_Racecar_ReturnsReversedString()
        {
            var testString = "racecar";

            var reversedString = ReversingString.ReverseStringByRecursion(testString);

            Assert.AreEqual("racecar", reversedString);
        }

        [TestMethod]
        public void ReverseStringByRecursion_Hello_World_ReturnsReversedString()
        {
            var testString = "hello world";

            var reversedString = ReversingString.ReverseStringByRecursion(testString);

            Assert.AreEqual("dlrow olleh", reversedString);
        }

        [TestMethod]
        public void ReverseStringByCharArray_Programming_ReturnsReversedString()
        {
            var testString = "programming";

            var reversedString = ReversingString.ReverseStringByCharArray(testString);

            Assert.AreEqual("gnimmargorp", reversedString);
        }

        [TestMethod]
        public void ReverseStringByCharArray_Racecar_ReturnsReversedString2()
        {
            var testString = "racecar";

            var reversedString = ReversingString.ReverseStringByCharArray(testString);

            Assert.AreEqual("racecar", reversedString);
        }

        [TestMethod]
        public void ReverseStringByCharArray_Hello_World_ReturnsReversedString()
        {
            var testString = "hello world";

            var reversedString = ReversingString.ReverseStringByCharArray(testString);

            Assert.AreEqual("dlrow olleh", reversedString);
        }

        [TestMethod]
        public void ReverseStringByBuiltInMethod_Racecar_ReturnsReversedString2()
        {
            var testString = "racecar";

            var reversedString = ReversingString.ReverseStringBuiltInMethod(testString);

            Assert.AreEqual("racecar", reversedString);
        }

        [TestMethod]
        public void ReverseStringByBuiltInMethod_Programming_ReturnsReversedString()
        {
            var testString = "programming";

            var reversedString = ReversingString.ReverseStringBuiltInMethod(testString);

            Assert.AreEqual("gnimmargorp", reversedString);
        }

        [TestMethod]
        public void ReverseStringByBuiltInMethod_Hello_World_ReturnsReversedString()
        {
            var testString = "hello world";

            var reversedString = ReversingString.ReverseStringBuiltInMethod(testString);

            Assert.AreEqual("dlrow olleh", reversedString);
        }
    }
}
