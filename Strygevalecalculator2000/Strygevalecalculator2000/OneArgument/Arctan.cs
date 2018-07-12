using System;

namespace Strygevalecalculator2000.OneArgument
{
    public class ArctanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// method, that calculates arctan(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Atan(argument)</returns>
        public double Calculate(double argument)
        {
            
            return Math.Atan(argument);
        }
    
    }
}
