using NUnit.Framework;
using Strygevalecalculator2000.OneArgument;

namespace ProjectTest.OneArgument
{
    class ArcctgTests
    {
        [TestCase(0.1, 1.4711276)]
        [TestCase(0.2, 1.3734007)]
        public void CalculationAdditionTest(double firstArgument, double result)
        {
            var calculator = new ArcctgCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult, 0.00001);
        }
    }
}
