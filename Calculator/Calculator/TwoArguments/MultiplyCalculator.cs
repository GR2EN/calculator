namespace Calculator.TwoArguments
{
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Gets multiplying of two numbers.
        /// </summary>
        /// <param name="firstOperand">
        /// First operand.
        /// </param>
        /// <param name="secondOperand">
        /// Second operand.
        /// </param>
        /// <returns>
        /// Result of multiplying two arguments  <see cref="double"/>.
        /// </returns>
        public double Calculate(double firstOperand, double secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
