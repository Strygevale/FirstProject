using System;

namespace Calculator.TwoArguments
{
    /// <summary>
    /// factory, that choses a  two argument calculating class by its name
    /// </summary>
    public class TwoArgumentsFactory
    {
        /// <summary>
        /// that choses a  two argument calculating class by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Sum() or Minus() or Multiply() or Division() or XinY() or XinReverseY() or Max() or Min() Remain() or Average()</returns>
        public static ITwoArgumentsCalculator CreateCalculator(string name) {
            switch (name)
            {
                case "sum":
                    return new Sum();
                case "minus":
                    return new Minus();
                case "multiply":
                    return new Multiply();
                case "division":
                    return new Division();
                case "xiny":
                    return new XinY();
                case "xinreversey":
                    return new XinReverseY();
                case "max":
                    return new Max();
                case "min":
                    return new Min();
                case "remain":
                    return new Remain();
                case "average":
                    return new Average();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
     
    }
}
