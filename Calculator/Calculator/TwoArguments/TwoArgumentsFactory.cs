using System;

namespace Calculator.TwoArguments
{
    public class TwoArgumentsFactory
    {
        /// <summary>
        /// Gets an exemplar of inherit-class depending of button name.
        /// </summary>
        /// <param name="buttonName">
        /// Button name.
        /// </param>
        /// <returns>
        /// Exemlar of inherit-class <see cref="ITwoArgumentsCalculator"/>.
        /// </returns>
        public static ITwoArgumentsCalculator CreateCalculatorByButtonName(string buttonName)
        {
            switch (buttonName)
            {
                case "ButtonAddition":
                    return new AdditionCalculator();
                case "ButtonSubstraction":
                    return new SubstractionCalculator();
                case "ButtonMultiplication":
                    return new MultiplyCalculator();
                case "ButtonDivision":
                    return new DivisionCalculator();
                default:
                    throw new Exception("Неизвестная операция.");
            }
        }
    }
}
