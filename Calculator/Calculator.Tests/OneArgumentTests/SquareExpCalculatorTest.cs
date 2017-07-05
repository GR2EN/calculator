using Calculator.OneArgumentFactory;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class SquareExpCalculatorTest
    {
        [TestCase(3, 9)]
        [TestCase(4, 16)]
        [TestCase(-5, 25)]
        public void SquareExpOfArgumentAreEqualTo(double argument, double expected)
        {
            var squareExpCalculator = new SquareExpCalculator();
            var actualResult = squareExpCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
