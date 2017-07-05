using System;

namespace Calculator.OneArgument
{
    public class CotangensCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            if (argument == 0 && argument == Math.PI)
            {
                throw new Exception("Value can't be zero or Pi");
            }
            return 1 / Math.Tan(argument);
        }
    }
}
