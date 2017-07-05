namespace Calculator.OneArgument
{
    public class FractionCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return 1 / argument;
        }
    }
}
