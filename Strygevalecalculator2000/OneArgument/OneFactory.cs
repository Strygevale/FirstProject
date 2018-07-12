using System;

namespace Strygevalecalculator2000.OneArgument
{
    /// <summary>
    /// factory, that choses a single argument calculating class by its name
    /// </summary>
    public static class OneFactory
    {
        /// <summary>
        /// method, that choses a single argument calculating class by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>SqrtRoot() or Logarithm() or Sin() or Cos() or Tan() or Xin2() or Arcsin() or Arccos() or Arctan() or Arcctg() or Ctg()</returns>
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
