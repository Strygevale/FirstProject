using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class CtgTests
    {
        [TestCase(0.5, 1.8304877)]
        [TestCase(1, 0.6420926)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Ctg();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.00001);
        }
    }
}
