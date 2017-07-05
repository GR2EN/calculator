using System;

namespace Calculator.OneArgumentFactory
{
    public class CubeExpCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Pow(argument, 3);
        }
    }
}
