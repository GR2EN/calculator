using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class TwoArgumentsFactoryTest
    {
        [TestCase("ButtonAddition", typeof(AdditionCalculator))]
        [TestCase("ButtonSubstraction", typeof(SubstractionCalculator))]
        [TestCase("ButtonMultiplication", typeof(MultiplyCalculator))]
        [TestCase("ButtonDivision", typeof(DivisionCalculator))]
        public void CreateCalculatorByButtonNameTest(string calculatorName, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculatorByButtonName(calculatorName);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
