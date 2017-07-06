using System;

namespace Calculator.OneArgument
{
    public class LnCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets natural logarifm of argument
        /// </summary>
        /// <param name="argument">Initial value</param>
        /// <returns>Natural logarifm of argument</returns>
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("Value can't be negative");
            }

            return Math.Log(argument);
        }
    }
}
