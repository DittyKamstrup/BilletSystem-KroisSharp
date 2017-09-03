using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class KøretøjTests
    {
        [TestMethod()]
        public void NummerpladeLængeTest7()
        {
            //arrange
            Bil bil = new Bil();
            //act
            bil.Nummerplade = "1234567";
            int nummerpladelængde = bil.NummerpladeLænge();
            //assert
            Assert.AreEqual(7, nummerpladelængde);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void NummerpladeLængeTest8()
        {
            //arrange
            Bil bil = new Bil();
            //act
            bil.Nummerplade = "12345678";
            int nummerpladelængde = bil.NummerpladeLænge();
            //vi har ikker assert med da vi forventer den thrower

        }

        [TestMethod()]
        public void BrobizzRabatTestTrue()
        {
            //arrange
            Bil bil = new Bil();
            //act
            int bropris = bil.BrobizzRabat();
            //assert
            //bemærk vi bruger 230 da vi arbejder med int!!
            Assert.AreEqual(230, bropris);
        }
    }
}