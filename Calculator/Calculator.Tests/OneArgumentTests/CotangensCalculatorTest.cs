using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class CotangensCalculatorTest
    {
        /// <summary>
        /// Testing of method cotangent calculating.
        /// </summary>
        /// <param name="argument">
        /// Initial value.
        /// </param>
        /// <param name="expected">
        /// Expected result.
        /// </param>
        [TestCase(0.5, 1.83048772171)]
        [TestCase(1, 0.64209261593)]
        public void CotangensOfArgumentAreEqualToExpected(double argument, double expected)
        {
            var cotangensCalculator = new CotangensCalculator();
            var actualResult = cotangensCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult, 0.0000000001);
        }

        /// <summary>
        /// Testing exceptions.
        /// </summary>
        /// <param name="argument">
        /// Exception values.
        /// </param>
        [TestCase(0)]
        [TestCase(Math.PI)]
        public void CtgExceptions(double argument)
        {
            var cotangensCalculator = new CotangensCalculator();
            Assert.Throws<Exception>(() => cotangensCalculator.Calculate(argument));
        }
    }
}
