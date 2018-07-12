using NUnit.Framework;
using Strygevalecalculator2000.OneArgument;

namespace ProjectTest.OneArgument
{
    [TestFixture]
    class SqrtRootTests
    {
        [TestCase(64, 8)]
        [TestCase(81, 9)]
        public void CalculationAdditionTest(double firstArgument, double result)
        {
            var calculator = new SqrtRootCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult, 0.00001);
        }
 
    }
}
