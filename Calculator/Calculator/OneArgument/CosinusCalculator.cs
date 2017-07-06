using System;

namespace Calculator.OneArgument
{
    public class CosinusCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets cosine of argument in radians
        /// </summary>
        /// <param name="argument">Initial value</param>
        /// <returns>Cosine of argument</returns>
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
