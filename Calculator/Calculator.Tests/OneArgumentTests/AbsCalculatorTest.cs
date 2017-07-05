using Calculator.OneArgumentFactory;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class AbsCalculatorTest
    {
        [TestCase(-71, 71)]
        [TestCase(2, 2)]
        public void CalculateAbsoluteValue(double argument, double expected)
        {
            var absCalculator = new AbsCalculator();
            var actualResult = absCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
