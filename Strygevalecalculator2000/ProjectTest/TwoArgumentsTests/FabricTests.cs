using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strygevalecalculator2000;

namespace FabricTest
{
    [TestFixture]
    public class FabricCalculatorTests
    {
        [TestCase("addition", typeof(AdditionCalculator))]
        [TestCase("substraction", typeof(SubstractionCalculator))]
        [TestCase("multiply", typeof(MultiplicationCalculator))]
        [TestCase("division", typeof(DivisionCalculator))]
        [TestCase("average", typeof(AverageCalculator))]
        [TestCase("max", typeof(MaxCalculator))]
        [TestCase("min", typeof(MinCalculator))]
        [TestCase("remain", typeof(RemainCalculator))]
        [TestCase("xiny", typeof(XinYCalculator))]
        [TestCase("xinreversey", typeof(XinReverseYCalculator))]
        public void CalculatorTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }

    }
}