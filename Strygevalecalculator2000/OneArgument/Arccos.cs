using System;

namespace Strygevalecalculator2000.OneArgument
{
    
    public class ArccosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// method, that calculates arccos(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Acos(argument)</returns>
        public double Calculate(double argument)
        {
            if (argument < -1 || argument > 1)
            {
                throw new Exception("Арк от 0");
            }
            return Math.Acos(argument);
        }
    }
}
