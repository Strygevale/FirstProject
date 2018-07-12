using System;

namespace Strygevalecalculator2000.OneArgument
{
    
    public class ArcctgCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// method, that calculates arcctg(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Atan(1 / argument)</returns>
        public double Calculate(double argument)
        {
            return Math.Atan(1 / argument);
        }

    }
     
}
