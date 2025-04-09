using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_start;

namespace csharp_start_tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void FToC_32F_Returns0C()
        {
            Program program = new Program();
            int result = program.FToC(32);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FToC_212F_Returns100C()
        {
            Program program = new Program();
            int result = program.FToC(212);
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void CToF_0C_Returns32F()
        {
            Program program = new Program();
            int result = program.CToF(0);
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void CToF_100C_Returns212F()
        {
            Program program = new Program();
            int result = program.CToF(100);
            Assert.AreEqual(212, result);
        }

        [TestMethod]
        public void FToC_NegativeFahrenheit_ReturnsExpectedCelsius()
        {
            Program program = new Program();
            int result = program.FToC(-40); // -40°F = -40°C
            Assert.AreEqual(-40, result);
        }

        [TestMethod]
        public void CToF_NegativeCelsius_ReturnsExpectedFahrenheit()
        {
            Program program = new Program();
            int result = program.CToF(-40); // -40°C = -40°F
            Assert.AreEqual(-40, result);
        }
    }
}