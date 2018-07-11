using System;

namespace Strygevalecalculator2000
{
    public class XinYCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method, that returns first argument in second`s degree
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>Math.Pow(firstArgument, secondArgument)</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            
            return Math.Pow(firstArgument, secondArgument);
        }
    }


}
