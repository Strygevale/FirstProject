using NUnit.Framework;
using NUnit.Framework.Internal;
using Strygevalecalculator2000;

namespace SinTest
{
    [TestFixture]
    public class SinCalculatorTests
    {
        [Test]
        public void SinCalculatorTest()
        {
            SinCalculator calculator = new SinCalculator();
            Assert.AreEqual(0, calculator.Calculate(0));
        }
        [TestCase(0, 0)]
        [TestCase(5, -0.95892)]
        [TestCase(-7, -0.65698)]
        public void CalculationAdditionTest(double firstArgument, double result)
        {
            var calculator = new SinCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult, 0.00001);
        }
    }
}