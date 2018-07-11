using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strygevalecalculator2000;
using Strygevalecalculator2000.OneArgument;

namespace OneFabricTest
{
    [TestFixture]
    public class OneFabricCalculatorTests
    {
        [TestCase("sin", typeof(SinCalculator))]
        [TestCase("cos", typeof(CosCalculator))]
        public void CalculatorTest(string name, Type type)
        {
            var calculator = OneFabric.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }

    }
}