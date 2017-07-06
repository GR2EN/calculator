using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class DivisionCalculatorTest
    {
        /// <summary>
        /// Testing division method
        /// </summary>
        /// <param name="firstValue">First operand</param>
        /// <param name="secondValue">Second operand</param>
        /// <param name="expected">Result of operation</param>
        [TestCase(21, 3, 7)]
        [TestCase(9, 4, 2.25)]
        [TestCase(-9, 3, -3)]
        public void FirstDivisonSecondAreEqualTo(double firstValue, double secondValue, double expected)
        {
            var divisionCalculator = new DivisionCalculator();
            var actualResult = divisionCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
