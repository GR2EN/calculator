using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class SinusCalculatorTest
    {
        /// <summary>
        /// Testing method of calculating sinus of argument.
        /// </summary>
        /// <param name="argument">
        /// Initial value.
        /// </param>
        /// <param name="expected">
        /// Expected result.
        /// </param>
        [TestCase(0, 0)]
        [TestCase(0.5, 0.4794255386)]
        [TestCase(1, 0.8414709848)]
        public void SinusOfArgumentAreEqualToExpected(double argument, double expected)
        {
            var sinusCalculator = new SinusCalculator();
            var actualResult = sinusCalculator.Calculate(argument);
            Assert.AreEqual(expected, actualResult, 0.0000000001);
        }
    }
}
