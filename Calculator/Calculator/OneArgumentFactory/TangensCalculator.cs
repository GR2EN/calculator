using System;

namespace Calculator.OneArgumentFactory
{
    public class TangensCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
