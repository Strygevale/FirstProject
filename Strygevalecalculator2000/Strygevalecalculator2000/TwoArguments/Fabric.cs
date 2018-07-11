using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Strygevalecalculator2000
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "addition": return new AdditionCalculator();
                case "substraction": return new SubstractionCalculator();
                case "multiply": return new MultiplicationCalculator();
                case "divide": return new DivisionCalculator();
                case "xiny": return new XinYCalculator();
                case "xinreversey": return new XinReverseYCalculator();
                case "max": return new MaxCalculator();
                case "min": return new MinCalculator();
                case "remain":return new RemainCalculator();
                case "average": return new AverageCalculator();
                default: throw new Exception("Error");
            }
        }
    }
}
