using System;

namespace Calculator.OneArgument
{
    public class SinusCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets sinus value of argument in radians.
        /// </summary>
        /// <param name="argument">
        /// Initial value.
        /// </param>
        /// <returns>
        /// Sinus value of argument <see cref="double"/>.
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
