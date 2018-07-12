using System;
using NUnit.Framework;
using Strygevalecalculator2000.TwoArguments;

namespace ProjectTest.TwoArguments
{
    [TestFixture]
    public class FabricCalculatorTests
    {
        [TestCase("addition", typeof(AdditionCalculator))]
        [TestCase("substraction", typeof(SubstractionCalculator))]
        [TestCase("multiply", typeof(MultiplicationCalculator))]
        [TestCase("divide", typeof(DivisionCalculator))]
        [TestCase("average", typeof(AverageCalculator))]
        [TestCase("max", typeof(MaxCalculator))]
        [TestCase("min", typeof(MinCalculator))]
        [TestCase("remain", typeof(RemainCalculator))]
        [TestCase("xiny", typeof(XinYCalculator))]
        [TestCase("xinreversey", typeof(XinReverseYCalculator))]
        public void CalculatorTest(string name, Type type)
        {
            var calculator = Factory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }

    }
}