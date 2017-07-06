using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class OneArgumentFactoryTest
    {
        /// <summary>
        /// Testing an exemplar of inherit-class depending of button name.
        /// </summary>
        /// <param name="buttonName">
        /// Button name.
        /// </param>
        /// <param name="type">
        /// Type of inherit-class.
        /// </param>
        [TestCase("AbsButton", typeof(AbsCalculator))]
        [TestCase("CosinusButton", typeof(CosinusCalculator))]
        [TestCase("CotangensButton", typeof(CotangensCalculator))]
        [TestCase("CubeExpButton", typeof(CubeExpCalculator))]
        [TestCase("ExpButton", typeof(ExpCalculator))]
        [TestCase("FractionalButton", typeof(FractionCalculator))]
        [TestCase("LnButton", typeof(LnCalculator))]
        [TestCase("SinusButton", typeof(SinusCalculator))]
        [TestCase("SqrtButton", typeof(SqrtCalculator))]
        [TestCase("SquareExpButton", typeof(SquareExpCalculator))]
        [TestCase("TangensButton", typeof(TangensCalculator))]
        public void CreateCalculatorByButtonNameTest(string buttonName, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculatorByButtonName(buttonName);
            Assert.IsInstanceOf(type, calculator);
        }

        /// <summary>
        /// Testing create calculator by unknown operation name.
        /// </summary>
        /// <param name="buttonName">
        /// Unknown operation name.
        /// </param>
        [TestCase("UnknownOperation")]
        public void CreateCalculatorByUnknownOperationName(string buttonName)
        {
            Assert.Throws<Exception>(() => OneArgumentFactory.CreateCalculatorByButtonName(buttonName));
        }
    }
}
