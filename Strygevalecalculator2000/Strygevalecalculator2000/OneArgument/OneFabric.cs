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
                case "root":return new SqrtRootCalculator();
                case "ln": return new LogarithmCalculator();
                case "tan": return new TanCalculator();
                case "x2": return new Xin2Calculator();
                case "arcsin": return new ArcsinCalculator();
                case "arccos": return new ArccosCalculator();
                case "arctan": return new ArctanCalculator();
                case "ctg": return new CtgCalculator();
                case "arcctg": return new ArcctgCalculator();
                default: throw new Exception("Error");
            }
        }
    }
}
