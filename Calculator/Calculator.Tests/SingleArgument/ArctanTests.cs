using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class ArctanTests
    {
        [TestCase(1, 0.7853981)]
        [TestCase(0, 0)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Arctan();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.00001);
        }
        
    }
}
