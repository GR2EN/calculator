using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class FractionCalculatorTest
    {
        /// <summary>
        /// Testing method of calculation fraction of form 1/argument.
        /// </summary>
        /// <param name="argument">
        /// Initial value.
        /// </param>
        /// <param name="expected">
        /// Expected result.
        /// </param>
        [TestCase(1, 1)]
        [TestCase(0.5, 2)]
        [TestCase(5, 0.2)]
        public void NumeratorOfOneDivisionOnArgument(double argument, double expected)
        {
            var fractionCalculator = new FractionCalculator();
            var actualResult = fractionCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult);
        }

        /// <summary>
        /// Exception testing.
        /// </summary>
        /// <param name="argument">
        /// Initial value.
        /// </param>
        [TestCase(0)]
        public void ArgumentIsZero(double argument)
        {
            var calculator = new FractionCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(argument));
        }
    }
}
