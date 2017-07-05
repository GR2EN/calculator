using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class AdditionCalculatorTest
    {
        [TestCase(3, 4, 7)]
        [TestCase(1, 8, 9)]
        [TestCase(74, 6, 80)]
        public void FirstPlusSecondAreEqualToExpected(double firstValue, double secondValue, double expected)
        {
            var additionCalculator = new AdditionCalculator();
            var actualResult = additionCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
