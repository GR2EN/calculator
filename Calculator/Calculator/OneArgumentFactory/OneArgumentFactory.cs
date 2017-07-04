using System;

namespace Calculator.OneArgumentFactory
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
                default:
                    throw new Exception("Unknown calculator name");
            }
        }
    }
}
