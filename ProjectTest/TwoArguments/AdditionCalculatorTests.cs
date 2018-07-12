using NUnit.Framework;
using Strygevalecalculator2000.TwoArguments;

namespace ProjectTest.TwoArguments
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
            [Test]
             public void AdditionCalculatorTest()
             {
                AdditionCalculator calculator = new AdditionCalculator();
                Assert.AreEqual(3, calculator.Calculate(2, 1));
            }
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculationAdditionTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new AdditionCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}
