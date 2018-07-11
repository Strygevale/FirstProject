using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strygevalecalculator2000
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
