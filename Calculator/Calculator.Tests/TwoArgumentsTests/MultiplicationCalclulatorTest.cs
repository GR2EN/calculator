using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class MultiplicationCalclulatorTest
    {
        /// <summary>
        /// Testing multiplication method.
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
        [TestCase(2, 2, 4)]
        [TestCase(4, 8, 32)]
        [TestCase(-7, -3, 21)]
        public void FirstMultiplySecondAreEqualToExpected(double firstValue, double secondValue, double expected)
        {
            var multiplicationCalculator = new MultiplyCalculator();
            var actualResult = multiplicationCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
