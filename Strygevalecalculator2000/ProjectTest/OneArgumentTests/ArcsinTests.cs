using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Strygevalecalculator2000;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class ArcsinTests
    {
        [TestCase(0.5, 0.5235987)]
        [TestCase(0.3, 0.3046926)]
        public void CalculationAdditionTest(double firstArgument, double result)
        {
            var calculator = new ArcsinCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult, 0.00001);
        }
    }


}

