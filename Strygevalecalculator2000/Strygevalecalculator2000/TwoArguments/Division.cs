using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strygevalecalculator2000
{
    public class DivisionCalculator : ITwoArgumentsCalculator

    {
        /// <summary>
        /// calculate function division
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
            return firstArgument / secondArgument;
        }
    }
}

