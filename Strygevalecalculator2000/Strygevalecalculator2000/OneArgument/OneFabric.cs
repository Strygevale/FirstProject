using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strygevalecalculator2000.OneArgument
{
    public static class OneFabric
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "sin": return new SinCalculator();
                case "cos": return new CosCalculator();
                default: throw new Exception("Error");
            }
        }
    }
}
