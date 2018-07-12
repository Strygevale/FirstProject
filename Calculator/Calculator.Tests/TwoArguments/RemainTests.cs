using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class RemainTests
    {
        [TestCase(5, 3, 2)]
        [TestCase(7, 4, 3)]
        [TestCase(9, 5, 4)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Remain();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
