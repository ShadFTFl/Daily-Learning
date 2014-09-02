
using System;
using CalculatorLib;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorFixture
    {

        [Test]
        public void AddTest()
        {
            Calculator aCalculator = new Calculator();
            double result = aCalculator.Add(10.4, 2.3);
            Assert.AreEqual(12.7,result);
        }

        [Test]
        public void Subtract()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Subtract(10.4, 2.4);
            Assert.AreEqual(8, result,0.01);

        }
        [Test]
        public void AddTestForNegativeNumber()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Add(-5.4, 2.3);
            Assert.AreEqual(-3.1, result, 0.01);

        }
        [Test]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(6.0, 3.0);
            Assert.AreEqual(2.0, result,0.01); 
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroTest()
        {
            Calculator calculator = new Calculator();
            calculator.Divide(3, 0);
        }
    
    }
}
