namespace Calculator.TwoArguments
{
    public interface ITwoArgumentsCalculator
    {
        /// <summary>
        /// Method of calculating with two arguments.
        /// </summary>
        /// <param name="firstArgument">
        /// First operand.
        /// </param>
        /// <param name="secondArgument">
        /// Second operand.
        /// </param>
        /// <returns>
        /// Exemplar of inherit-class <see cref="ITwoArgumentsCalculator"/>.
        /// </returns>
        double Calculate(double firstArgument, double secondArgument);
    }
}
