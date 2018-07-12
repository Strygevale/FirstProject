using System;

namespace Calculator.SingleArgument
{
    
    public class Arccos : ISingleArgumentCalculatorcs
    {
        /// <summary>
        /// method, that calculates arccos(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Acos(argument)</returns>
        public double SingleCalculate(double argument)
        {
            if (argument < -1 || argument > 1)
            {
                throw new Exception("Арк от 0");
            }
            return Math.Acos(argument);
        }

    }
}
