using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class CubeExpCalculatorTest
    {
        /// <summary>
        /// Testing method of calculating cube exponent of argument.
        /// </summary>
        /// <param name="argument">
        /// Initial value.
        /// </param>
        /// <param name="expected">
        /// Expected result.
        /// </param>
        [TestCase(3, 27)]
        [TestCase(4, 64)]
        [TestCase(-5, -125)]
        public void CubeExpOfArgumentAreEqualTo(double argument, double expected)
        {
            var cubeExpCalculator = new CubeExpCalculator();
            var actualResult = cubeExpCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
