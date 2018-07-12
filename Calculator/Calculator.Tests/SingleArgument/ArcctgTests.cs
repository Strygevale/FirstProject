using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    class ArcctgTests
    {
        [TestCase(0.1, 1.4711276)]
        [TestCase(0.2, 1.3734007)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Arcctg();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
