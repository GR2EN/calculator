using Calculator.OneArgumentFactory;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    public class ExpCalculatorTest
    {
        [TestCase(0, 1)]
        [TestCase(0.5, 1.6487212707)]
        [TestCase(1, 2.71828182846)]
        public void ExponentOfArgumentAreEqualToExpected(double argument, double expected)
        {
            var expCalculator = new ExpCalculator();
            var actualResult = expCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult, 0.0000000001);
        }
    }
}
