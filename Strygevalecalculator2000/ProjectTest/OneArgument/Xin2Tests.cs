using NUnit.Framework;
using Strygevalecalculator2000.OneArgument;

namespace ProjectTest.OneArgument
{
    [TestFixture]
    class Xin2Tests
    {
        [TestCase(10, 100)]
        [TestCase(3, 9)]
        public void CalculationAdditionTest(double firstArgument, double result)
        {
            var calculator = new Xin2Calculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult, 0.00001);
        }
    }
}
