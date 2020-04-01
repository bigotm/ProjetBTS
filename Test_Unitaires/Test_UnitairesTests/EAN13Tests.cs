using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Unitaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Unitaires.Tests
{
    [TestClass()]
    public class EAN13Tests
    {
        [TestMethod()]
        public void EAN13Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PoidsPairTest()
        {
            EAN13 target = new EAN13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 });
            int expected = 81;
            int actual;
            actual = target.PoidsPair();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PoidsImpairTest()
        {
            EAN13 target = new EAN13(new int[] {4,7,1,9,5,1,2,0,0,2,8,8});
            int expected = 20;
            int actual;
            actual = target.PoidsImpair();
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void ResteTest()
        {
            EAN13 target = new EAN13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 });
            int expected = 1;
            int actual = target.Reste();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CleTest()
        {
            EAN13 target = new EAN13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 });
            int expected = 9;
            int actual = target.Cle();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            EAN13 target = new EAN13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8 });
            string expected = "4719-5120-0288-9";
            string actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Ean13CtorTest_13()
        {
            try
            {
                EAN13 target = new EAN13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8, 8,0 });
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "un code Ean 13 doit etre un tableau de 12 entiers");
                
            }
            Assert.Fail("Aucune exeception n'a été soulevée");
        }

        public void Ean13CtorTest_11()
        {
            try
            {
                EAN13 target = new EAN13(new int[] { 4, 7, 1, 9, 5, 1, 2, 0, 0, 2, 8});
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "un code Ean 13 doit etre un tableau de 12 entiers");
                return;
            }
            Assert.Fail("Aucune exeception n'a été soulevée");
        }
    }
}