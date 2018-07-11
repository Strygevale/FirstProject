using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using Strygevalecalculator2000;

namespace SubstractionTest
{
    [TestFixture]
    public class SubstractionCalculatorTests
    {
        [Test]
        public void SubstractionCalculatorTest()
        {
            SubstractionCalculator calculator = new SubstractionCalculator();
            Assert.AreEqual(1, calculator.Calculate(2, 1));
        }
        [TestCase(0, 0, 0)]
        [TestCase(10, 4, 6)]
        [TestCase(-4, -3, -1)]
        public void CalculationSubstractionTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new SubstractionCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}
