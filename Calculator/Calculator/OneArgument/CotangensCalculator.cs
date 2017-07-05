using System;

namespace Calculator.OneArgument
{
    public class CotangensCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return 1 / Math.Tan(argument);
        }
    }
}
