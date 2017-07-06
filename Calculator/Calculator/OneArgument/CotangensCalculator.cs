using System;

namespace Calculator.OneArgument
{
    public class CotangensCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets cotangent of argument in radians.
        /// </summary>
        /// <param name="argument">
        /// Initial value.
        /// </param>
        /// <returns>
        /// Cotangent of value <see cref="double"/>.
        /// </returns>
        public double Calculate(double argument)
        {
            if (argument == 0 && argument == Math.PI)
            {
                throw new Exception("Число не может быть нулем или равным Pi/2.");
            }
            return 1 / Math.Tan(argument);
        }
    }
}
