using System;

namespace Strygevalecalculator2000.OneArgument
{
    
    public class SqrtRootCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// method, that calculates sqrt(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Sqrt(argument)</returns>
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("Корень из отрицательного");
            }
            return Math.Sqrt(argument);
        }
    }
}
