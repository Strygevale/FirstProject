using System;
using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class ArccosTests
    {
        [TestCase(0.5, 1.0471975)]
        [TestCase(0.3, 1.2661036)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Arccos();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.00001);
        }
        [Test]
        public void CalculateTest()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("root");
            Assert.Throws<Exception>(() => singlecalculator.SingleCalculate(-5));
        }





    }
}
