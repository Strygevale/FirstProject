using System;

namespace Calculator.TwoArguments
{
    public class XinReverseY : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method, that returns first argument in reverse second`s degree
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>Math.Pow(firstArgument, 1 / secondArgument)</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {

            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }


}
