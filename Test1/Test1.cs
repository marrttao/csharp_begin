using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_start;

namespace csharp_start_tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void FizzBuzz_Input15_ReturnsFizzBuzz()
        {
            // Arrange
            var program = new Program();

            // Act
            var result = program.GetFizzBuzzResult(15);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void FizzBuzz_Input9_ReturnsFizz()
        {
            var program = new Program();
            var result = program.GetFizzBuzzResult(9);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void FizzBuzz_Input10_ReturnsBuzz()
        {
            var program = new Program();
            var result = program.GetFizzBuzzResult(10);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FizzBuzz_Input7_Returns7()
        {
            var program = new Program();
            var result = program.GetFizzBuzzResult(7);
            Assert.AreEqual("7", result);
        }
    }
}