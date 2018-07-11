
namespace Calculator.TwoArguments
{
    public class Average : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method, that return arithmetic average
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>(firstArgument + secondArgument)/2</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument)/2;
        }
    }


}
