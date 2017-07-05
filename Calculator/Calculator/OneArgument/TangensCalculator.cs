using System;

namespace Calculator.OneArgument
{
    public class TangensCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
