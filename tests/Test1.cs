using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_start;

namespace csharp_start_tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SwapDigits_FirstAndLast_SwapsCorrectly()
        {
            // Arrange
            Program program = new Program();
            char[] input = { '1', '2', '3', '4', '5', '6' };

            // Act
            char[] result = program.SwapDigits(0, 5, input);

            // Assert
            CollectionAssert.AreEqual(new char[] { '6', '2', '3', '4', '5', '1' }, result);
        }

        [TestMethod]
        public void SwapDigits_SameIndex_ReturnsSameArray()
        {
            Program program = new Program();
            char[] input = { '1', '2', '3', '4', '5', '6' };
            char[] result = program.SwapDigits(2, 2, input);
            CollectionAssert.AreEqual(new char[] { '1', '2', '3', '4', '5', '6' }, result);
        }

        [TestMethod]
        public void SwapDigits_MiddleSwap_SwapsCorrectly()
        {
            Program program = new Program();
            char[] input = { '9', '8', '7', '6', '5', '4' };
            char[] result = program.SwapDigits(1, 3, input);
            CollectionAssert.AreEqual(new char[] { '9', '6', '7', '8', '5', '4' }, result);
        }
    }
}