﻿using System;
using NUnit.Framework;
using Strygevalecalculator2000.TwoArguments;

namespace ProjectTest.TwoArguments
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]
        public void DivisionCalculatorTest()
        {
            DivisionCalculator calculator = new DivisionCalculator();
            Assert.AreEqual(4, calculator.Calculate(20, 5));
        }

        [TestCase(0, 1, 0)]
        [TestCase(10, 5, 2)]
        [TestCase(-4, -2, 2)]
        public void CalculationAdditionTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new DivisionCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, actualResult);
        }

        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = Factory.CreateCalculator("divide");
            Assert.Throws<Exception>(() => calculator.Calculate(5, 0));
        }
    }

}
