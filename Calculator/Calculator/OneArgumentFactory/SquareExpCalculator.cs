using System;

namespace Calculator.OneArgumentFactory
{
    public class SquareExpCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Pow(argument, 2);
        }
    }
}
