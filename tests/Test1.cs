using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_start;

namespace csharp_start_tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void DateToDayOfWeek_KnownDate_ReturnsCorrectDay()
        {
            // Arrange
            Program program = new Program();
            string input = "09.04.2025"; // Среда (Wednesday)

            // Act
            string result = program.DateToDayOfWeek(input);

            // Assert
            Assert.AreEqual("Wednesday", result);
        }

        [TestMethod]
        public void DateToSeason_WinterDate_ReturnsWinter()
        {
            Program program = new Program();
            string result = program.DateToSeason("15.01.2023");
            Assert.AreEqual("Winter", result);
        }

        [TestMethod]
        public void DateToSeason_SpringDate_ReturnsSpring()
        {
            Program program = new Program();
            string result = program.DateToSeason("10.03.2022");
            Assert.AreEqual("Spring", result);
        }

        [TestMethod]
        public void DateToSeason_SummerDate_ReturnsSummer()
        {
            Program program = new Program();
            string result = program.DateToSeason("01.08.2020");
            Assert.AreEqual("Summer", result);
        }

        [TestMethod]
        public void DateToSeason_AutumnDate_ReturnsAutumn()
        {
            Program program = new Program();
            string result = program.DateToSeason("30.10.2019");
            Assert.AreEqual("Autumn", result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void DateToSeason_InvalidFormat_ThrowsFormatException()
        {
            Program program = new Program();
            program.DateToSeason("2024-12-01"); // неправильный формат
        }
    }
}