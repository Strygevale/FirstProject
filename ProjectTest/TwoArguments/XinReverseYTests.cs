using NUnit.Framework;
using Strygevalecalculator2000.TwoArguments;

namespace ProjectTest.TwoArguments
{
    [TestFixture]
    class XinReverseYTests
    {
        [TestCase(5, 1, 5)]
        [TestCase(2, 1, 2)]
        [TestCase(16, 1, 16)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new XinReverseYCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
