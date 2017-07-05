using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class SqrtCalculatorTest
    {
        [TestCase(25, 5)]
        [TestCase(16, 4)]
        [TestCase(4, 2)]
        public void SqrtOfArgumentAreEqualTo(double argument, double expected)
        {
            var sqrtCalculator = new SqrtCalculator();
            var actualResult = sqrtCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
