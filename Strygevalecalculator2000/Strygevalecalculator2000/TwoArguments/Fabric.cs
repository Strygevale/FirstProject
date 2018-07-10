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
                default: throw new Exception("Error");
            }
        }
    }
}
