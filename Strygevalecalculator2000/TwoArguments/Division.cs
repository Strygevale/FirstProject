using System;

namespace Strygevalecalculator2000.TwoArguments
{
    public class DivisionCalculator : ITwoArgumentsCalculator

    {
        /// <summary>
        /// calculate function divide
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// check second argument
        /// if second argument=0
        /// then error
        /// <returns>
        /// returns division of two argument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }

            return firstArgument / secondArgument;
        }
    }
}

