using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class XinReverseYTests
    {
        [TestCase(5, 1, 5)]
        [TestCase(2, 1, 2)]
        [TestCase(16, 1, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new XinReverseY();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
