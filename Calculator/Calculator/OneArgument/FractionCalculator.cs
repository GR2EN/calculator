using System;

namespace Calculator.OneArgument
{
    public class FractionCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            if (argument == 0)
            {
                throw new Exception("The value can't be zero");
            }

            return 1 / argument;
        }
    }
}
