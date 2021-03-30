using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace calculatortest
{
    [TestClass]
    public class CalculatorTest
    {
        public ICalculator c;

        private int num1;

        private int num2;

        private int addresult;
        

        [TestInitialize]

        public void TestSetup()

        {

            c = new Calculator();

            num1 = 15;

            num2 = 5;

            addresult = 20;
            

        }
        [TestMethod]
        public void ShouldAddTwoPositiveNumbers()

        {

            var result = c.Add(num1, num2);

            Assert.AreEqual(addresult, result);

        }



        [TestMethod]

        public void ShouldReturnFirstNumberIfSecondNumberIsZero()

        {

            var result = c.Add(num1, 0);

            Assert.AreEqual(num1, result);

        }

        [TestMethod]
        public void ShouldReturnSecondNumberIfFirstNumberIsZero()

        {

            var result = c.Add(0, num2);
            
            Assert.AreEqual(num2, result);

        }


    }
}
