namespace Calculator.TwoArguments
{
    public class Min : ITwoArgumentsCalculator
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
