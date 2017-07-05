using System;

namespace Calculator.OneArgumentFactory
{
    public class ExpCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }
    }
}
