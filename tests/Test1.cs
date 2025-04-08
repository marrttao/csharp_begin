using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_start;
using System;

namespace tests
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void ParseTwoNumbers_ValidInput_ReturnsCorrectArray()
        {
            Program p = new Program();
            int[] result = p.ParseTwoNumbers("10", "20");

            Assert.AreEqual(10, result[0]);
            Assert.AreEqual(20, result[1]);
        }

        [TestMethod]
        public void ParseTwoNumbers_InvalidInput_ThrowsFormatException()
        {
            Program p = new Program();
            Assert.ThrowsException<FormatException>(() => p.ParseTwoNumbers("abc", "20"));
        }

        [TestMethod]
        public void ParseTwoNumbers_EmptyInput_ThrowsFormatException()
        {
            Program p = new Program();
            Assert.ThrowsException<FormatException>(() => p.ParseTwoNumbers("", ""));
        }
    }
}