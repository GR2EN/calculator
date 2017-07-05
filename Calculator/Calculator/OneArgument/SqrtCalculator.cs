using System;

namespace Calculator.OneArgument
{
    public class SqrtCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sqrt(argument);
        }
    }
}
