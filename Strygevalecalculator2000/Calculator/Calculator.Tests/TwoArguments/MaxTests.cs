using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class MaxTests
    {
        
      [TestCase(5, 0, 5)]
      [TestCase(3, 4, 4)]
      [TestCase(7, 2, 7)]
       public void CalculateTest(double firstValue, double secondValue, double expected)
         {
            var calculator = new Max();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
          }
        }
}

