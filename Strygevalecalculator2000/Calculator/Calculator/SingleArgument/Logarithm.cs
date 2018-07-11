using System;

namespace Calculator.SingleArgument
{
    
    public class Logarithm : ISingleArgumentCalculatorcs
    {
        /// <summary>
        /// method, that calculates ln(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Log(argument)</returns>
        public double SingleCalculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("Логарифм отрицательного");
            }
            return Math.Log(argument);
        }
   
    }
}
