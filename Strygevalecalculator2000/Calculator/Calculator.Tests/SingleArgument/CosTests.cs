using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class CosTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 0.5403023)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Cos();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.00001);
        }
    }
}
