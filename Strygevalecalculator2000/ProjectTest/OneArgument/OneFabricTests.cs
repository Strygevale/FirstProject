using System;
using NUnit.Framework;
using Strygevalecalculator2000.OneArgument;

namespace ProjectTest.OneArgument
{
    [TestFixture]
    public class OneFabricCalculatorTests
    {
        [TestCase("sin", typeof(SinCalculator))]
        [TestCase("cos", typeof(CosCalculator))]
        [TestCase("tan", typeof(TanCalculator))]
        [TestCase("ln", typeof(LogarithmCalculator))]
        [TestCase("root", typeof(SqrtRootCalculator))]
        [TestCase("x2", typeof(Xin2Calculator))]
        [TestCase("ctg", typeof(CtgCalculator))]
        [TestCase("arccos", typeof(ArccosCalculator))]
        [TestCase("arcsin", typeof(ArcsinCalculator))]
        [TestCase("arctan", typeof(ArctanCalculator))]
        [TestCase("arcctg", typeof(ArcctgCalculator))]
        public void CalculatorTest(string name, Type type)
        {
            var calculator = OneFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }

    }
}