using System;

namespace Calculator.OneArgument
{
    public class FractionCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets fraction with 1 in a numerator.
        /// </summary>
        /// <param name="argument">
        /// Denominator value.
        /// </param>
        /// <returns>
        /// Fraction of form 1/argument <see cref="double"/>.
        /// </returns>
        public double Calculate(double argument)
        {
            if (argument == 0)
            {
                throw new Exception("Число не может быть нулем.");
            }

            return 1 / argument;
        }
    }
}
