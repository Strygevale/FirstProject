using System;

namespace Calculator.SingleArgument
{
    
    public class Arcctg : ISingleArgumentCalculatorcs
    {
        /// <summary>
        /// method, that calculates arcctg(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Atan(1 / argument)</returns>
        public double SingleCalculate(double argument)
        {
            return Math.Atan(1 / argument);
        }

    }
     
}
