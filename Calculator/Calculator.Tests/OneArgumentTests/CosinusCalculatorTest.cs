using Calculator.OneArgumentFactory;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class CosinusCalculatorTest
    {
        [TestCase(0, 1)]
        [TestCase(0.5, 0.87758256189)]
        [TestCase(1, 0.54030230586)]
        public void CosinusOfArgumentAreEqualToExpected(double argument, double expected)
        {
            var cosinusCalculator = new CosinusCalculator();
            var actualResult = cosinusCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult, 0.0000000001);
        }
    }
}
