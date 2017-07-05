using System;

namespace Calculator.OneArgument
{
    public class SquareExpCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
           return Math.Pow(argument, 2);
        }
    }
}
