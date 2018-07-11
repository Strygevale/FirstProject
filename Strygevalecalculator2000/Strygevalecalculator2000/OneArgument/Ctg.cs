using System;

namespace Strygevalecalculator2000
{
    
    public class CtgCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// method, that calculates ctg(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>1 / Math.Tan(argument)</returns>
        public double Calculate(double argument)
        {
            return 1 / Math.Tan(argument);
        }

    }
    
    
}
