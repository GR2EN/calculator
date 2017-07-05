using System;

namespace Calculator.OneArgumentFactory
{
    public class AbsCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}
