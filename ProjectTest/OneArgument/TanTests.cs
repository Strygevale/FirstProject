using NUnit.Framework;
using Strygevalecalculator2000.OneArgument;

namespace ProjectTest.OneArgument
{
    [TestFixture]
    class TanTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.5574077)]
        public void CalculationAdditionTest(double firstArgument, double result)
        {
            var calculator = new TanCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult, 0.00001);
        }
    }
}
