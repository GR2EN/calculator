using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class SqrtCalculatorTest
    {
        /// <summary>
        /// Testing method of calculating square root of argument
        /// </summary>
        /// <param name="argument">Initial value</param>
        /// <param name="expected">Expected result</param>
        [TestCase(25, 5)]
        [TestCase(16, 4)]
        [TestCase(4, 2)]
        public void SqrtOfArgumentAreEqualTo(double argument, double expected)
        {
            var sqrtCalculator = new SqrtCalculator();
            var actualResult = sqrtCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult);
        }

        /// <summary>
        /// Testing exceptions
        /// </summary>
        /// <param name="argument">Initial value</param>
        [TestCase(-1)]
        public void ArgumentIsLessThanZero(double argument)
        {
            var calculator = new SqrtCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(argument));
        }
    }
}
