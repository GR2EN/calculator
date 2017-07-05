using System;

namespace Calculator.OneArgument
{
    public class ExpCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }
    }
}
