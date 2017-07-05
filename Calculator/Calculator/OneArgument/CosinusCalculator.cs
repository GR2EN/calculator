using System;

namespace Calculator.OneArgument
{
    public class CosinusCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
