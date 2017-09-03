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
    public class BilTests
    {
        [TestMethod()]
        public void PrisTest240()
        {
            //arrange
            Bil bil = new Bil(false);

            //act
            int pris = bil.Pris();
            //assert
            Assert.AreEqual(240, pris);
        }

        /// <summary>
        /// kan denne test overhoved bruges? den giver hvad der er forventet men er den nyttig?
        /// </summary>
        [TestMethod()]
        public void PrisTest239()
        {
            //arrange
            Bil bil = new Bil(false);

            //act
            int pris = bil.Pris();
            //assert
            Assert.AreNotEqual(239, pris);
        }

        [TestMethod()]
        public void KøretøjTestBil()
        {
            //arrange
            Bil bil = new Bil(false);
            //act
            string køretøj = bil.Typekøretøj();
            //assert
            Assert.AreEqual("Bil", køretøj);
        }

        //igen er denne brugbar? 
        [TestMethod()]
        public void KøretøjTestBiil()
        {
            //arrange
            Bil bil = new Bil(false);
            //act
            string køretøj = bil.Typekøretøj();
            //assert
            Assert.AreNotEqual("biil", køretøj);
        }

        [TestMethod()]
        public void BrobizzRabatTestSøndag()
        {
            //arrange
            Bil bil = new Bil(false);
            DateTime dt = new DateTime(2017, 9, 3);
            //act
            bil.Dato = dt;
            //assert
            Assert.AreEqual(200, bil.BrobizzRabat());

        }

        
        [TestMethod()]
        public void BrobizzRabatMandag()
        {
            //arrange
            Bil bil = new Bil(false);
            DateTime dt = new DateTime(2017, 9, 4);
            //act
            bil.Dato = dt;
            //assert
            Assert.AreNotEqual(200, bil.BrobizzRabat());

        }

    }
}