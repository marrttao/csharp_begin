using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_start;

namespace csharp_start_tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void IsArmstrong_153_ReturnsTrue()
        {
            Program program = new Program();
            bool result = program.IsArmstrong(153); // 1^3 + 5^3 + 3^3 = 153
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsArmstrong_370_ReturnsTrue()
        {
            Program program = new Program();
            bool result = program.IsArmstrong(370); // 3^3 + 7^3 + 0^3 = 370
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsArmstrong_371_ReturnsTrue()
        {
            Program program = new Program();
            bool result = program.IsArmstrong(371); // 3^3 + 7^3 + 1^3 = 371
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsArmstrong_407_ReturnsTrue()
        {
            Program program = new Program();
            bool result = program.IsArmstrong(407); // 4^3 + 0^3 + 7^3 = 407
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsArmstrong_123_ReturnsFalse()
        {
            Program program = new Program();
            bool result = program.IsArmstrong(123); // 1^3 + 2^3 + 3^3 != 123
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsArmstrong_10_ReturnsFalse()
        {
            Program program = new Program();
            bool result = program.IsArmstrong(10); // 1^2 + 0^2 != 10
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsArmstrong_9_ReturnsTrue()
        {
            Program program = new Program();
            bool result = program.IsArmstrong(9); // 9^1 = 9
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsArmstrong_0_ReturnsTrue()
        {
            Program program = new Program();
            bool result = program.IsArmstrong(0); // 0^1 = 0
            Assert.IsTrue(result);
        }
    }
}
