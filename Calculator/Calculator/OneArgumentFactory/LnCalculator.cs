using System;

namespace Calculator.OneArgumentFactory
{
    public class LnCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Log(argument);
        }
    }
}
