using System;

namespace Calculator.OneArgumentFactory
{
    public class CosinusCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
