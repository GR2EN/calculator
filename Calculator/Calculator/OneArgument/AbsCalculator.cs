using System;

namespace Calculator.OneArgument
{
    public class AbsCalculator : IOneArgumentCalculator
    {   
        /// <summary>
        /// Gets absolute value of argument
        /// </summary>
        /// <param name="argument">Initial value</param>
        /// <returns>Absolute value of argument</returns>
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}
