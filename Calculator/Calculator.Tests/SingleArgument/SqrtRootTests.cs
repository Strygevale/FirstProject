using System;
using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class SqrtRootTests
    {
        [TestCase(64, 8)]
        [TestCase(81, 9)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new SqrtRoot();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void CalculateTest()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("root");
            Assert.Throws<Exception>(() => singlecalculator.SingleCalculate(-5));
        }
    }
}
