using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsignatieUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignatieMagazinBiblioteca;

namespace ConsignatieUI.Tests
{
    [TestClass()]
    public class ConsignatieTests
    {
        [TestMethod()]
        public void CalculProfitOwnerTest()
        {
            Furnizor f = new Furnizor();
            Item item = new Item("bla", "bla", 10, 7, false, f);
            Consignatie calcP = new Consignatie();

            Assert.AreEqual(calcP.CalculProfitOwner(item), 0); //succes
        }

        [TestMethod()]
        public void CalculProfitDepozitTest()
        {
            Furnizor f = new Furnizor();
            Item item = new Item("bla", "bla", 10, 7, false, f);
            Consignatie calcP = new Consignatie();

            Assert.AreEqual(0, calcP.CalculProfitDepozit(item)); //succes
        }
    }
}