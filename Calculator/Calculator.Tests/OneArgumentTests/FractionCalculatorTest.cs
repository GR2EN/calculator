using Calculator.OneArgumentFactory;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class FractionCalculatorTest
    {
        [TestCase(1, 1)]
        [TestCase(0.5, 2)]
        [TestCase(5, 0.2)]
        public void NumeratorOfOneDivisionOnArgument(double argument, double expected)
        {
            var fractionCalculator = new FractionCalculator();
            var actualResult = fractionCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
