using Calculator.TwoArgumentFactory;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class MultiplicationCalclulatorTest
    {
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
