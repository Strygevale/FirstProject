using System;
using Calculator.SingleArgument;
using NUnit.Framework;

namespace Calculator.Tests.SingleArgument
{
    [TestFixture]
    class SingleArgumentFactoryTest
    {
        [TestCase("sin", typeof(Sin))]
        [TestCase("cos", typeof(Cos))]
        [TestCase("tan", typeof(Tan))]
        [TestCase("ln", typeof(Logarithm))]
        [TestCase("root", typeof(SqrtRoot))]
        [TestCase("x2", typeof(Xin2))]
        [TestCase("ctg", typeof(Ctg))]
        [TestCase("arccos", typeof(Arccos))]
        [TestCase("arcsin", typeof(Arcsin))]
        [TestCase("arctan", typeof(Arctan))]
        [TestCase("arcctg", typeof(Arcctg))]
        public void SingleCalculateTest(string name, Type type)
        {
            var calculator = SingleArgumentFactory.CreateSingleCalculate(name);
            Assert.IsInstanceOf(type, calculator);
        }


    }
}
