using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Strygevalecalculator2000;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class LogarithmTests
    {
        [TestCase(1, 0)]
        [TestCase(2.71828, 1)]
        public void CalculationAdditionTest(double firstArgument, double result)
        {
            var calculator = new LogarithmCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult, 0.00001);
        }
    }
}
