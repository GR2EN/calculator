using System;

namespace Calculator.OneArgument
{
    public class SquareExpCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets square power of argument
        /// </summary>
        /// <param name="argument">Initial value</param>
        /// <returns>Square power of argument</returns>
        public double Calculate(double argument)
        {
           return Math.Pow(argument, 2);
        }
    }
}
