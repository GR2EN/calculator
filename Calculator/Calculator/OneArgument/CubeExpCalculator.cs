using System;

namespace Calculator.OneArgument
{
    public class CubeExpCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets cube power of argument
        /// </summary>
        /// <param name="argument">Initial value</param>
        /// <returns>Cube power of argument</returns>
        public double Calculate(double argument)
        {
            return Math.Pow(argument, 3);
        }
    }
}
