namespace Calculator.TwoArguments
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Gets division of two numbers.
        /// </summary>
        /// <param name="firstArgument">
        /// First operand.
        /// </param>
        /// <param name="secondArgument">
        /// Second operand.
        /// </param>
        /// <returns>
        /// Result of dividing two arguments <see cref="double"/>.
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
