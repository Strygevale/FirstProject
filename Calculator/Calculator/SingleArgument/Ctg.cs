using System;

namespace Calculator.SingleArgument
{
    
    public class Ctg : ISingleArgumentCalculatorcs
    {
        /// <summary>
        /// method, that calculates ctg(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>1 / Math.Tan(argument)</returns>
        public double SingleCalculate(double argument)
        {
            return 1 / Math.Tan(argument);
        }

    }
    
    
}
