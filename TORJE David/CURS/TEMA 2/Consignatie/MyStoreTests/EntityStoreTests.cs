using ConsignatieMagazinBiblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Tests
{
    [TestClass()]
    public class EntityStoreTests
    {
        [TestMethod()]
        public void CreateFurnizorTest()
        {
            Furnizor prov = new Furnizor("TORJE", "Timotei");

            Assert.IsNotNull(prov); //succes
        }

        [TestMethod()]
        public void CreateFurnizorComisionTest_toString()
        {
            Furnizor prov = new Furnizor("TORJE", "Timotei", .7);

            Assert.AreEqual(prov.toString, "TORJE Timotei - $0"); //succes
        }

        [TestMethod()]
        public void CreateItemTest()
        {
            Furnizor owner = new Furnizor();
            Item prov = new Item("TORJE", "Timotei", 15, 77, false, owner);

            Assert.IsNotNull(prov); //succes
        }
    }
}