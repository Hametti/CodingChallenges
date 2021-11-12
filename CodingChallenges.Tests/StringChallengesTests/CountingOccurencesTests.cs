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
    public class CountingOccurencesTests
    {
        [TestMethod]
        public void CountingOccurences_Hello_World_ReturnsThreeOccurencesForL()
        {
            string str = "Hello world";

            var strDictionary = CountingOccurences.OccurenceCount(str);

            Assert.AreEqual(3, strDictionary['l']);
        }

        [TestMethod]
        public void CountingOccurences_Hello_World_ReturnsTwoOccurencesForO()
        {
            string str = "Hello world";

            var strDictionary = CountingOccurences.OccurenceCount(str);

            Assert.AreEqual(2, strDictionary['o']);
        }

        [TestMethod]
        public void CountingOccurences_Hello_World_ReturnsOneOccurenceForE()
        {
            string str = "Hello world";

            var strDictionary = CountingOccurences.OccurenceCount(str);

            Assert.AreEqual(1, strDictionary['e']);
        }

        [TestMethod]
        public void CountingOccurences_EmptyString_ReturnsEmptyDictionary()
        {
            string str = "";

            var strDictionary = CountingOccurences.OccurenceCount(str);

            Assert.AreEqual(0, strDictionary.Count);
        }
    }
}
