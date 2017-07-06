using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class SubstractionCalculatorTest
    {
        /// <summary>
        /// Testing substraction method.
        /// </summary>
        /// <param name="firstValue">
        /// First operand.
        /// </param>
        /// <param name="secondValue">
        /// Second operand.
        /// </param>
        /// <param name="expected">
        /// Result of operation.
        /// </param>
        [TestCase(21, 1, 20)]
        [TestCase(14, 7, 7)]
        [TestCase(10, 91, -81)]
        public void FirstMinusSecondAreEqualToExpected(double firstValue, double secondValue, double expected)
        {
            var substractionCalculator = new SubstractionCalculator();
            var actualResult = substractionCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
