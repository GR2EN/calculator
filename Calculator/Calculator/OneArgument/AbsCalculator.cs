using System;

namespace Calculator.OneArgument
{
    public class AbsCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}
