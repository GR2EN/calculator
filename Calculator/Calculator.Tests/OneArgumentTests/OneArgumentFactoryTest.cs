using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class OneArgumentFactoryTest
    {
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
        public void CreateCalculatorByButtonNameTest(string calculatorName, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculatorByButtonName(calculatorName);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
