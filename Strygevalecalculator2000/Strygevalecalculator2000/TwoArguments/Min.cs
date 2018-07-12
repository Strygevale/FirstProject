namespace Strygevalecalculator2000.TwoArguments
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method, that returns lowest value
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>firstArgument or secondArgument</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument <= secondArgument)
            {
                return firstArgument;
            }
            return secondArgument;

        }
    }


}
