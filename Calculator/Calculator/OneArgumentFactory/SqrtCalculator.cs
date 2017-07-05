using System;

namespace Calculator.OneArgumentFactory
{
    public class SqrtCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sqrt(argument);
        }
    }
}
