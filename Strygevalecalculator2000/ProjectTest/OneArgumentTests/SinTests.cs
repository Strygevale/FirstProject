using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using Strygevalecalculator2000;

namespace SinTest
{
    [TestFixture]
    public class SinCalculatorTests
    {
        [Test]
        public void SinCalculatorTest()
        {
            SinCalculator calculator = new SinCalculator();
            Assert.AreEqual(0, calculator.Calculate(0));
        }
    }
}