using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using Strygevalecalculator2000;

namespace CosTest
{
    [TestFixture]
    public class CosCalculatorTests
    {
        [Test]
        public void CosCalculatorTest()
        {
            CosCalculator calculator = new CosCalculator();
            Assert.AreEqual(1, calculator.Calculate(0));
        }
        [TestCase(0, 1)]
        [TestCase(5, 0.28366)]
        [TestCase(-7, 0.75390)]
        public void CalculationAdditionTest(double firstArgument, double result)
        {
            var calculator = new CosCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult, 0.00001);
        }
    }
}