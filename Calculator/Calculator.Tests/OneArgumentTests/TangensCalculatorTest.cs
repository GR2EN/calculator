using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class TangensCalculatorTest
    {
        [TestCase(0, 0)]
        [TestCase(0.5, 0.54630248984)]
        [TestCase(1, 1.55740772465)]
        public void TangensOfArgumentAreEqualToExpected(double argument, double expected)
        {
            var tangensCalculator = new TangensCalculator();
            var actualResult = tangensCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult, 0.0000000001);
        }

        [TestCase(Math.PI / 2)]
        [TestCase(3 * Math.PI / 2)]
        public void TangensExceptions(double argument)
        {
            var tangensCalculator = new TangensCalculator();
            Assert.Throws<Exception>(() => tangensCalculator.Calculate(argument));
        }
    }
}
