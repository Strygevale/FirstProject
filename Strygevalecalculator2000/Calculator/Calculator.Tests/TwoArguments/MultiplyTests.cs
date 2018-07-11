using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class MultiplyTests
    {
        [TestCase(5, 10, 50)]
        [TestCase(6, 4, 24)]
        [TestCase(9, 3, 27)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Multiply();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
