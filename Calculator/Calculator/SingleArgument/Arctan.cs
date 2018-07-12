using System;

namespace Calculator.SingleArgument
{
    public class Arctan : ISingleArgumentCalculatorcs
    {
        /// <summary>
        /// method, that calculates arctan(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Atan(argument)</returns>
        public double SingleCalculate(double argument)
        {
            
            return Math.Atan(argument);
        }
    
    }
}
