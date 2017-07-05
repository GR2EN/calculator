using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class LnCalculatorTest
    {
        [TestCase(1, 0)]
        [TestCase(3, 1.09861228867)]
        [TestCase(5, 1.60943791243)]
        public void LogOfArgumentAreEqualTo(double argument, double expected)
        {
            var lnCalculator = new LnCalculator();
            var actualResult = lnCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult, 0.00000000001);
        }
    }
}
