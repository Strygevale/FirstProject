using System;

namespace Strygevalecalculator2000.OneArgument
{
    public class CosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate function cos(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// c
        /// <returns>
        ///returns result sin(x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
