using System;

namespace Calculator.OneArgument
{
    public class ExpCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets exponent of argument.
        /// </summary>
        /// <param name="argument">
        /// Initial value.
        /// </param>
        /// <returns>
        /// Exponent of argument <see cref="double"/>.
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }
    }
}
