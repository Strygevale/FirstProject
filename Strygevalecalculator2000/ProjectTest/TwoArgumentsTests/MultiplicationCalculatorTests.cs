using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using Strygevalecalculator2000;

namespace MultiplyTest
{
    [TestFixture]
    public class MultiplicationCalculatorTests
    {
        public void MultiplicationCalculatorTest()
        {
            MultiplicationCalculator calculator = new MultiplicationCalculator();
            Assert.AreEqual(20, calculator.Calculate(4, 5));
        }
    }
}
