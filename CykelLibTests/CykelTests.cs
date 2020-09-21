using Microsoft.VisualStudio.TestTools.UnitTesting;
using CykelLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace CykelLib.Tests
{
    [TestClass()]
    public class CykelTests
    {

        private Cykel cykel;

        [TestInitialize]
        public void Init()
        {
            cykel = new Cykel();
        }
        [TestMethod()]
        public void CykelFarveTest()
        {
            cykel.Farve = "rød";
            Assert.ThrowsException<ArgumentNullException>(() => cykel.Farve = null);
            Assert.AreEqual("rød", cykel.Farve);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel.Farve = "" );
        }

        [TestMethod()]
        public void CykelPrisTest()
        {
            cykel.Pris = 100;
            Assert.AreEqual(100, cykel.Pris);
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> cykel.Pris = 0);
        }
        [TestMethod()]
        public void CykelGearTest()
        {
            cykel.Gear = 3;
            Assert.AreEqual(3, cykel.Gear);
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> cykel.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> cykel.Gear = 33);
        }

        //[TestMethod()]
        //public void ToStringTest()
        //{
        //    Assert.Fail();
        //}
    }
}