using Calculator.OneArgumentFactory;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class CotangensCalculatorTest
    {
        [TestCase(0.5, 1.83048772171)]
        [TestCase(1, 0.64209261593)]
        public void CotangensOfArgumentAreEqualToExpected(double argument, double expected)
        {
            var cotangensCalculator = new CotangensCalculator();
            var actualResult = cotangensCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult, 0.0000000001);
        }
    }
}
