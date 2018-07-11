using System;

namespace Strygevalecalculator2000
{
    
    public class LogarithmCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// method, that calculates ln(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Log(argument)</returns>
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("Логарифм отрицательного");
            }
            return Math.Log(argument);
        }
   
    }
}
