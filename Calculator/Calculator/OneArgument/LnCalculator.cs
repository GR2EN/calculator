using System;

namespace Calculator.OneArgument
{
    public class LnCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets natural logarifm of argument.
        /// </summary>
        /// <param name="argument">
        /// Initial value.
        /// </param>
        /// <returns>
        /// Natural logarifm of argument <see cref="double"/>.
        /// </returns>
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("Число не может быть отрицательным.");
            }

            return Math.Log(argument);
        }
    }
}
