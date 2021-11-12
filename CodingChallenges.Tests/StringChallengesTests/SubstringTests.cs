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
    public class SubstringTests
    {
        [TestMethod]
        public void Substring_abcd_ReturnsAllSubstrings()
        {
            var str = "abcd";

            var result = Substrings.AllPossibleSubstrings(str);

            Assert.AreEqual("a ab abc abcd b bc bcd c cd d ", result);
        }

        [TestMethod]
        public void Substring_Empty_String_ReturnsAllSubstrings()
        {
            var str = "";

            var result = Substrings.AllPossibleSubstrings(str);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void Substring_Single_Character_ReturnsAllSubstrings()
        {
            var str = "a";

            var result = Substrings.AllPossibleSubstrings(str);

            Assert.AreEqual("a ", result);
        }
    }
}
