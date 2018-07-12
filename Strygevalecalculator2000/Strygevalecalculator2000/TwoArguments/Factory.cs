using System;

namespace Strygevalecalculator2000.TwoArguments
{
    /// <summary>
    /// factory, that choses a  two argument calculating class by its name
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// that choses a  two argument calculating class by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Sum() or Minus() or Multiply() or Division() or XinY() or XinReverseY() or Max() or Min() Remain() or Average()</returns>
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
