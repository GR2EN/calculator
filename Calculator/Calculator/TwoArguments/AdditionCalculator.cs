namespace Calculator.TwoArguments
{
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Gets sum of two arguments
        /// </summary>
        /// <param name="firstArgument">First operand</param>
        /// <param name="secondArgument">Second operand</param>
        /// <returns>Sum of two arguments</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
