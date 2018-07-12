﻿namespace Strygevalecalculator2000.TwoArguments
{
    public class AverageCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method, that return arithmetic  average operation
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>(firstArgument + secondArgument)/2</returns>
       
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument) / 2;
        }
    }


}
