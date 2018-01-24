using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Lommeregner lommeregner;
        [TestInitialize]
        public void Init()
        {
            lommeregner = new Lommeregner();
        }
        [TestMethod]
        public void Test_Add()
        {
            Assert.AreEqual(7, lommeregner.Calculate(2, 5, Udregning.Add));
        }
        [TestMethod]
        public void Test_Subtract()
        {
            Assert.AreEqual(-3, lommeregner.Calculate(2, 5, Udregning.Subtract));
        }

        [TestMethod]
        public void Test_Multiply()
        {
            Assert.AreEqual(10, lommeregner.Calculate(2, 5, Udregning.Multiply));
        }
        [TestMethod]
        public void Test_Divide()
        {
            Assert.AreEqual(0.4, lommeregner.Calculate(2, 5, Udregning.Divide));
        }
    }

}
