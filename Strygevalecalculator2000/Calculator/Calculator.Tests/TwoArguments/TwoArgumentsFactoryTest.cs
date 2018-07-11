using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class TwoArgumentsFactoryTest
    {
        [TestCase("sum", typeof(Sum))]
        [TestCase("minus", typeof(Minus))]
        [TestCase("multiply", typeof(Multiply))]
        [TestCase("division", typeof(Division))]
        [TestCase("average", typeof(Average))]
        [TestCase("max", typeof(Max))]
        [TestCase("min", typeof(Min))]
        [TestCase("remain", typeof(Remain))]
        [TestCase("xiny", typeof(XinY))]
        [TestCase("xinreversey", typeof(XinReverseY))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
