using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strygevalecalculator2000
{
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculate function addition
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// returns addition of two argument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
