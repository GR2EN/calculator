using System;

namespace Calculator.OneArgument
{
    public class SqrtCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("The value can't be negative");
            }
            
            return Math.Sqrt(argument);
        }
    }
}
