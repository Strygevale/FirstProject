using NUnit.Framework;
using NUnit.Framework.Internal;
using Strygevalecalculator2000;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class XinYTests
    {
        [TestCase(5, 1, 5)]
        [TestCase(3, 2, 9)]
        [TestCase(7, 2, 49)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new XinYCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
