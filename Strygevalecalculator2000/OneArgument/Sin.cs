using System;

namespace Strygevalecalculator2000.OneArgument
{
    public class SinCalculator : IOneArgumentCalculator

    {
        /// <summary>
        /// calculate function sin(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// sin(x) is calculate
        /// <returns>
        ///returns result cos(x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
