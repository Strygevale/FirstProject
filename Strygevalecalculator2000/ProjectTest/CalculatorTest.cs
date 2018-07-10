using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strygevalecalculator2000;

namespace ProjectTest
{
    [TestFixture]
    public class CalculateTest
    {
        [Test]
        public void AdditionCalculatorTest()
        {
            AdditionCalculator calculator = new AdditionCalculator();
            Assert.AreEqual(3, calculator.Calculate(2,1));
        }
        [Test]
        public void SubstractionCalculatorTest()
        {
            SubstractionCalculator calculator = new SubstractionCalculator();
            Assert.AreEqual(1, calculator.Calculate(2,1));
        }
        [Test]
        public void MultiplicationCalculatorTest()
        {
            MultiplicationCalculator calculator = new MultiplicationCalculator();
            Assert.AreEqual(20, calculator.Calculate(4, 5));
        }
        [Test]
        public void DivisionCalculatorTest()
        {
            DivisionCalculator calculator = new DivisionCalculator();
            Assert.AreEqual(4, calculator.Calculate(20, 5));
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
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculationSubstractionTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new AdditionCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, actualResult);
        }

        [TestCase("addition", typeof(AdditionCalculator))]
        [TestCase("substraction", typeof(SubstractionCalculator))]
        public void CalculatorTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type,calculator);

        }
    }
}
