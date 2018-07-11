using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Strygevalecalculator2000;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class CtgTests
    {
        [TestCase(0.5, 1.8304877)]
        [TestCase(1, 0.6420926)]
        public void CalculationAdditionTest(double firstArgument, double result)
        {
            var calculator = new CtgCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult, 0.00001);
        }
    
    }
}
