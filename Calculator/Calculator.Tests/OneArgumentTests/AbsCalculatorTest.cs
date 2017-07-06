using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class AbsCalculatorTest
    {
        /// <summary>
        /// Testing method of calculating absolute value of argument
        /// </summary>
        /// <param name="argument">Initial value</param>
        /// <param name="expected">Expected result</param>
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
