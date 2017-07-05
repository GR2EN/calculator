using System;

namespace Calculator.OneArgument
{
    public class LnCalculator : IOneArgumentCalculator
    {
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
