using System;

namespace Calculator.OneArgument
{
    public class OneArgumentFactory
    {
        /// <summary>
        /// Gets an exemplar of inherit-class depending of button name.
        /// </summary>
        /// <param name="buttonName">
        /// Button name.
        /// </param>
        /// <returns>
        /// Exemlar of inherit-class <see cref="IOneArgumentCalculator"/>.
        /// </returns>
        public static IOneArgumentCalculator CreateCalculatorByButtonName(string buttonName)
        {
            switch (buttonName)
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
                    throw new Exception("Неизвестная операция.");
            }
        }
    }
}
