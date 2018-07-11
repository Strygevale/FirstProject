using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strygevalecalculator2000
{
    public class MultiplicationCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculate function myltiplication
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// myltiplication is calculate
        /// <returns>
        /// returns myltiplication of two argument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}

