using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_begin;

namespace csharp_begin_tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ConnectInputs_AllSingleDigits_ReturnsConcatenatedNumber()
        {
            // Arrangee
            string[] input = { "1", "2", "3", "4" };

            // Act
            int result = Program.connect_inputs(input);

            // Assert
            Assert.AreEqual(1234, result);
        }

        [TestMethod]
        public void ConnectInputs_DoubleDigits_ReturnsConcatenatedNumber()
        {
            string[] input = { "12", "34", "56", "78" };
            int result = Program.connect_inputs(input);
            Assert.AreEqual(12345678, result);
        }

        [TestMethod]
        public void ConnectInputs_LeadingZeros_ReturnsNumberWithoutZeros()
        {
            string[] input = { "0", "01", "2", "3" };
            int result = Program.connect_inputs(input);
            Assert.AreEqual(123, result); // 00123 → 123
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ConnectInputs_InvalidInput_ThrowsFormatException()
        {
            string[] input = { "1", "a", "3", "4" };
            Program.connect_inputs(input); // должна быть ошибка
        }
    }
}