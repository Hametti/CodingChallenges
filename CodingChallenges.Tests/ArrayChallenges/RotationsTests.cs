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
    public class RotationsTests
    {
        [TestMethod]
        public void LeftCircularRotation_12345_Returns23451()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };

            array = Rotations.LeftCircularRotation(array);

            string result = "";

            foreach (int number in array)
                result += number + " ";

            Assert.AreEqual("2 3 4 5 1 ", result);
        }

        [TestMethod]
        public void LeftCircularRotationByNewArray_12345_Returns23451()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };

            array = Rotations.LeftCircularRotationByNewArray(array);

            string result = "";

            foreach (int number in array)
                result += number + " ";

            Assert.AreEqual("2 3 4 5 1 ", result);
        }

        [TestMethod]
        public void RightCircularRotation_12345_Returns51234()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };

            array = Rotations.RightCircularRotation(array);

            string result = "";

            foreach (int number in array)
                result += number + " ";

            Assert.AreEqual("5 1 2 3 4 ", result);
        }

        [TestMethod]
        public void RightCircularRotationByNewArray_12345_Returns51234()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };

            array = Rotations.RightCircularRotationByNewArray(array);

            string result = "";

            foreach (int number in array)
                result += number + " ";

            Assert.AreEqual("5 1 2 3 4 ", result);
        }

        [TestMethod]
        public void RightCircularRotationDifferentMethod_12345_Returns51234()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };

            array = Rotations.RightCircularRotationDifferentMethod(array);

            string result = "";

            foreach (int number in array)
                result += number + " ";

            Assert.AreEqual("5 1 2 3 4 ", result);
        }
    }
}
