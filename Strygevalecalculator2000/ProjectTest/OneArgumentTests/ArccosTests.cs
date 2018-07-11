using System;
using NUnit.Framework;
using Strygevalecalculator2000;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class ArccosTests
    {
        [TestCase(0.5, 1.0471975)]
        [TestCase(0.3, 1.2661036)]
        public void CalculationAdditionTest(double firstArgument, double result)
        {
            var calculator = new ArccosCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult, 0.00001);
        }
    }
}
