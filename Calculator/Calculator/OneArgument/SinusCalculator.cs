using System;

namespace Calculator.OneArgument
{
    public class SinusCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
