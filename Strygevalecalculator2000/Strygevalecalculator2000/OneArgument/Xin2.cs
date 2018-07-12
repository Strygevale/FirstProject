using System;

namespace Strygevalecalculator2000.OneArgument
{
    
    public class Xin2Calculator : IOneArgumentCalculator
    {
        /// <summary>
        /// method, that calculates (argument)^2
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Pow(argument, 2)</returns>
        public double Calculate(double argument)
        {
            return Math.Pow(argument, 2);
        }
    }
}
