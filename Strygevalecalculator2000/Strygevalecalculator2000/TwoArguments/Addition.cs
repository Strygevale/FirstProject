namespace Strygevalecalculator2000.TwoArguments
{
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculate function addition
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// returns addition of two argument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
