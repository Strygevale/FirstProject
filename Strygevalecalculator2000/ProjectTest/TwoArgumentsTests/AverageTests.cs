using NUnit.Framework;
using NUnit.Framework.Internal;
using Strygevalecalculator2000;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class AverageTests
    {
        
       [TestCase(2, 4, 3)]
       [TestCase(8, 8, 8)]
       [TestCase(3, 3, 3)]
       public void CalculateTest(double firstValue, double secondValue, double expected)
          {
                var calculator = new AverageCalculator();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
          }
        }
}

