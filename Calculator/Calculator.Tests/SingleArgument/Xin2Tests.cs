using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class Xin2Tests
    {
        [TestCase(10, 100)]
        [TestCase(3, 9)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Xin2();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
