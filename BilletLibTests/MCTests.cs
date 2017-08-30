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
    public class MCTests
    {
        [TestMethod()]
        public void PrisTest125()
        {
            //arrange
            MC MC = new MC();
            //act
            int pris = MC.Pris();
            //assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void KøretøjTestMC()
        {
            //arrange
            MC MC = new MC();
            //act
            string Køretøj = MC.Typekøretøj();
            //assert
            Assert.AreEqual("MC", Køretøj);
        }
    }
}