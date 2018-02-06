using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingTerningApp2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_Equal()
        {
            OpgaveTerningApp2.Terning t = new OpgaveTerningApp2.Terning(1);
            Assert.AreEqual(1, t.Værdi);

        }

        [TestMethod]
        public void TestMethod2_NotEqual()
        {

            OpgaveTerningApp2.LudoTerning t2 = new OpgaveTerningApp2.LudoTerning(3);
            Assert.AreNotEqual(1, t2.Værdi);

        }


        [TestMethod]
        public void TestMethod3_Equal()
        {

            OpgaveTerningApp2.LudoTerning t2 = new OpgaveTerningApp2.LudoTerning(3);
            Assert.AreEqual(t2 as OpgaveTerningApp2.Terning, (OpgaveTerningApp2.LudoTerning) t2);

        }
    }
}
