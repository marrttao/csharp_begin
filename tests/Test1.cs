using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_start;

namespace csharp_start_tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void IsPerfectNumber_6_ReturnsTrue()
        {
            // Arrange
            Program program = new Program();

            // Act
            bool result = program.IsPerfectNumber(6);

            // Assert
            Assert.IsTrue(result); // 6 — совершенное число, делители: 1, 2, 3 → 1 + 2 + 3 = 6
        }

        [TestMethod]
        public void IsPerfectNumber_28_ReturnsTrue()
        {
            // Arrange
            Program program = new Program();

            // Act
            bool result = program.IsPerfectNumber(28);

            // Assert
            Assert.IsTrue(result); // 28 — совершенное число, делители: 1, 2, 4, 7, 14 → 1 + 2 + 4 + 7 + 14 = 28
        }

        [TestMethod]
        public void IsPerfectNumber_12_ReturnsFalse()
        {
            // Arrange
            Program program = new Program();

            // Act
            bool result = program.IsPerfectNumber(12);

            // Assert
            Assert.IsFalse(result); // 12 не совершенное число
        }

        [TestMethod]
        public void IsPerfectNumber_1_ReturnsFalse()
        {
            // Arrange
            Program program = new Program();

            // Act
            bool result = program.IsPerfectNumber(1);

            // Assert
            Assert.IsFalse(result); // 1 не совершенное число
        }
    }
}