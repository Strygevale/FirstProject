using System;
using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class LogarithmTests
    {
        [TestCase(1, 0)]
        [TestCase(2.71828, 1)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Logarithm();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
        [Test]
        public void CalculateTest()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("root");
            Assert.Throws<Exception>(() => singlecalculator.SingleCalculate(-5));
        }
    }
}
