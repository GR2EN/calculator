using System;

namespace Calculator.OneArgument
{
    public class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculatorByButtonName(string calculatorName)
        {
            switch (calculatorName)
            {
                case "SinusButton":
                    return new SinusCalculator();
                case "CosinusButton":
                    return new CosinusCalculator();
                case "TangensButton":
                    return new TangensCalculator();
                case "CotangensButton":
                    return new CotangensCalculator();
                case "ExpButton":
                    return new ExpCalculator();
                case "LnButton":
                    return new LnCalculator();
                case "SqrtButton":
                    return new SqrtCalculator();
                case "SquareExpButton":
                    return new SquareExpCalculator();
                case "CubeExpButton":
                    return new CubeExpCalculator();
                case "FractionalButton":
                    return new FractionCalculator();
                case "AbsButton":
                    return new AbsCalculator();
                default:
                    throw new Exception("Unknown calculator name");
            }
        }
    }
}
