namespace Calculator.TwoArguments
{
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstOperand, double secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
