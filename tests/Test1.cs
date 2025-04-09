using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_start;
using System.Collections.Generic;

namespace csharp_start_tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GetEvenNumbersInRange_StartLessThanEnd_ReturnsCorrectList()
        {
            Program program = new Program();
            List<int> result = program.GetEvenNumbersInRange(1, 10);
            CollectionAssert.AreEqual(new List<int> { 2, 4, 6, 8, 10 }, result);
        }

        [TestMethod]
        public void GetEvenNumbersInRange_StartGreaterThanEnd_ReturnsCorrectList()
        {
            Program program = new Program();
            List<int> result = program.GetEvenNumbersInRange(10, 1);
            CollectionAssert.AreEqual(new List<int> { 2, 4, 6, 8, 10 }, result);
        }

        [TestMethod]
        public void GetEvenNumbersInRange_OnlyOneEvenNumber()
        {
            Program program = new Program();
            List<int> result = program.GetEvenNumbersInRange(3, 4);
            CollectionAssert.AreEqual(new List<int> { 4 }, result);
        }

        [TestMethod]
        public void GetEvenNumbersInRange_NoEvenNumbers()
        {
            Program program = new Program();
            List<int> result = program.GetEvenNumbersInRange(1, 1); // 1 is odd
            CollectionAssert.AreEqual(new List<int> { }, result);
        }

        [TestMethod]
        public void GetEvenNumbersInRange_SameStartAndEnd_EvenNumber()
        {
            Program program = new Program();
            List<int> result = program.GetEvenNumbersInRange(2, 2);
            CollectionAssert.AreEqual(new List<int> { 2 }, result);
        }
    }
}