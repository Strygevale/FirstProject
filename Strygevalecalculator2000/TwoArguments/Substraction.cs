namespace Strygevalecalculator2000.TwoArguments
{
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculate function substraction
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// myltiplication is performed
        /// <returns>
        /// returns substraction from the first argument of the second argument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}

