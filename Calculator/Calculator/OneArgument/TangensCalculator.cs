using System;

namespace Calculator.OneArgument
{
    public class TangensCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Gets tangent value of argument in radians.
        /// </summary>
        /// <param name="argument">
        /// Initial argument.
        /// </param>
        /// <returns>
        /// Tangent of argument <see cref="double"/>.
        /// </returns>
        public double Calculate(double argument)
        {
            if (argument == Math.PI / 2 || argument == 3 * Math.PI / 2)
            {
                throw new Exception("Число не может быть равным Pi/2 или 3Pi/2.");
            }

            return Math.Tan(argument);
        }
    }
}
