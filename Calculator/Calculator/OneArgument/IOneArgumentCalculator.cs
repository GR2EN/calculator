namespace Calculator.OneArgument
{
    public interface IOneArgumentCalculator
    {
        /// <summary>
        /// Factory interface
        /// </summary>
        /// <param name="argument">Initial argument</param>
        /// <returns>A value depending on calculator inherit-class</returns>
        double Calculate(double argument);
    }
}
