namespace Calculator.TwoArguments
{
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Gets substraction of two arguments
        /// </summary>
        /// <param name="firstArgument">First operand</param>
        /// <param name="secondArgument">Second operand</param>
        /// <returns>Substraction of two arguments</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
