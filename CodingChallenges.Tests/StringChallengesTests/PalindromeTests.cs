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
    public class PalindromeTests
    {
        [TestMethod]
        public void Palindrome_Racecar_ReturnsTrue()
        {
            var testString = "RaCEcar";

            var result = Palindrome.PalindromeCheck(testString);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Palindrome_Book_ReturnsTrueFalse()
        {
            var testString = "Book";

            var result = Palindrome.PalindromeCheck(testString);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Palindrome_Step_On_No_Pets_ReturnsTrue()
        {
            var testString = "Step ON nO pEts";

            var result = Palindrome.PalindromeCheck(testString);

            Assert.AreEqual(true, result);
        }
    }
}
