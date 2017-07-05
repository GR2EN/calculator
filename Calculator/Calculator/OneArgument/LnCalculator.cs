using System;

namespace Calculator.OneArgument
{
    public class LnCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Log(argument);
        }
    }
}
