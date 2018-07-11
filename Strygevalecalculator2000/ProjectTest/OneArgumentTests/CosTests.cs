using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using Strygevalecalculator2000;

namespace CosTest
{
    [TestFixture]
    public class CosCalculatorTests
    {
        [Test]
        public void CosCalculatorTest()
        {
            CosCalculator calculator = new CosCalculator();
            Assert.AreEqual(1, calculator.Calculate(0));
        }
    }
}