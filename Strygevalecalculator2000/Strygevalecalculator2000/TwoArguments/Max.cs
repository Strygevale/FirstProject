using System;

namespace Strygevalecalculator2000
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method, that returns largest value
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>firstArgument or secondArgument</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument >= secondArgument)
            {
                return firstArgument;
            }
           return secondArgument;
           
        }
    }
}
