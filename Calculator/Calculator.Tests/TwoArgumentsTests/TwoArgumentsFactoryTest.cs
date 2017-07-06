using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class TwoArgumentsFactoryTest
    {
        /// <summary>
        /// Testing method of creating a class.
        /// </summary>
        /// <param name="buttonName">
        /// Button name.
        /// </param>
        /// <param name="type">
        /// Type of class.
        /// </param>
        [TestCase("ButtonAddition", typeof(AdditionCalculator))]
        [TestCase("ButtonSubstraction", typeof(SubstractionCalculator))]
        [TestCase("ButtonMultiplication", typeof(MultiplyCalculator))]
        [TestCase("ButtonDivision", typeof(DivisionCalculator))]
        public void CreateCalculatorByButtonNameTest(string buttonName, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculatorByButtonName(buttonName);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
