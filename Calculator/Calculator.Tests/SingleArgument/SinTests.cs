using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class SinTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.8414709)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Sin();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.00001);
        }
    }
}
