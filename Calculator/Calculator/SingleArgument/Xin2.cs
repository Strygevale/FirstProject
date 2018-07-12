using System;

namespace Calculator.SingleArgument
{
    
    public class Xin2 : ISingleArgumentCalculatorcs
    {
        /// <summary>
        /// method, that calculates (argument)^2
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Pow(argument, 2)</returns>
        public double SingleCalculate(double argument)
        {
            return Math.Pow(argument, 2);
        }
    }
}
