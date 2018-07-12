﻿using NUnit.Framework;
using Strygevalecalculator2000.OneArgument;

namespace ProjectTest.OneArgument
{
    [TestFixture]
    class ArctanTests
    {
        [TestCase(1, 0.7853981)]
        [TestCase(0, 0)]
        public void CalculationAdditionTest(double firstArgument, double result)
        {
            var calculator = new ArctanCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult, 0.00001);
        }

    }
}
