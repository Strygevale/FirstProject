using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class DivisionTests
    {
        [TestCase(6, 3, 2)]
        [TestCase(8, 4, 2)]
        [TestCase(9, 3, 3)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("division");
            Assert.Throws<Exception>(() => calculator.Calculate(5, 0));

        }
    }
}
