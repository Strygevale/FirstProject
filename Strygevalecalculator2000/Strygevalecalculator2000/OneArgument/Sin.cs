using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strygevalecalculator2000
{
    public class SinCalculator : IOneArgumentCalculator

    {
        /// <summary>
        /// calculate function sin(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// sin(x) is calculate
        /// <returns>
        ///returns result cos(x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
