using System;

namespace Calculator.OneArgument
{
    public class SqrtCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets square root of argument.
        /// </summary>
        /// <param name="argument">
        /// Initial value.
        /// </param>
        /// <returns>
        /// Square root of argument <see cref="double"/>.
        /// </returns>
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("Число не может быть отрицательным.");
            }
            
            return Math.Sqrt(argument);
        }
    }
}
