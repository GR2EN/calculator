using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    public class ExpCalculatorTest
    {
        /// <summary>
        /// Testing method of calculating exponent of argument
        /// </summary>
        /// <param name="argument">Initial value</param>
        /// <param name="expected">Expected result</param>
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
