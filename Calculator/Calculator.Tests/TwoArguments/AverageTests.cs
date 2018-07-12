using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class AverageTests
    {
        
       [TestCase(2, 4, 3)]
       [TestCase(8, 8, 8)]
       [TestCase(3, 3, 3)]
       public void CalculateTest(double firstValue, double secondValue, double expected)
          {
                var calculator = new Average();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
          }
        }
}

