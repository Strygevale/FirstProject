using System;

namespace Strygevalecalculator2000.OneArgument
{
    
    public class TanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// method, that calculates tan(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Tan(argument)</returns>
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    
    }
}
