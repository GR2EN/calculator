using System;

namespace Calculator.OneArgument
{
    public class SqrtCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets square root of argument
        /// </summary>
        /// <param name="argument">Initial value</param>
        /// <returns>Square root of argument</returns>
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("The value can't be negative");
            }
            
            return Math.Sqrt(argument);
        }
    }
}
