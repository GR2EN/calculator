using System;

namespace Calculator.OneArgumentFactory
{
    public class SinusCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
