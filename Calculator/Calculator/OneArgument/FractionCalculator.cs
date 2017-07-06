using System;

namespace Calculator.OneArgument
{
    public class FractionCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets fraction with 1 in a numerator
        /// </summary>
        /// <param name="argument">Denominator value</param>
        /// <returns>Fraction of form 1/argument</returns>
        public double Calculate(double argument)
        {
            if (argument == 0)
            {
                throw new Exception("The value can't be zero");
            }

            return 1 / argument;
        }
    }
}
