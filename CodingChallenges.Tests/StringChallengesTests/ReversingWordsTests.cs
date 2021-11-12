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
    public class ReversingWordsTests
    {
        [TestMethod]
        public void ReverseWordsOrder_SampleSentence_ReturnsReversedWords()
        {
            var testString = "   Welcome  to C# corner  ";

            var reversedString = ReversingWords.ReverseWordsOrder(testString);

            Assert.AreEqual("  corner C# to  Welcome   ", reversedString);
        }

        [TestMethod]
        public void ReverseWordsOrder_SampleSentenceWithoutEmptyFields_ReturnsReversedWords()
        {
            var testString = "Welcome to C# corner";

            var reversedString = ReversingWords.ReverseWordsOrder(testString);

            Assert.AreEqual("corner C# to Welcome", reversedString);
        }

        [TestMethod]
        public void ReverseEachWord_SampleSentence_ReturnsReversedWords()
        {
            var testString = "Welcome to Csharp corner";

            var reversedString = ReversingWords.ReverseEachWord(testString);

            Assert.AreEqual("emocleW ot prahsC renroc", reversedString);
        }
    }
}
