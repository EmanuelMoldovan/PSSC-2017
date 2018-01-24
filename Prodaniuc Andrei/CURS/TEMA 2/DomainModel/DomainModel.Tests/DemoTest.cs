using DomainModel.Business;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Tests
{
    [TestFixture]
    class DemoTest
    {
        [Test]
        public void CreateMgazinTest_ShouldPass()
        {
            var magazin = MagazinFactory.Instance.CreateMagazin("Magazin1", "RO325448");

            Assert.IsNotNull(magazin);
        }

        [Test]
        public void AdaugareProdusTest_ShouldPass()
        {
            var magazin = MagazinFactory.Instance.CreateMagazin("Magazin1", "RO325448");

            magazin.AdaugareProdus("Produs1", "102466100041");

            Assert.IsNotNull(magazin);
            Assert.AreEqual(magazin.NumarProduse(), 1);
        }

        [Test]
        public void EditareProdusTest_ShouldPass()
        {
            var magazin = MagazinFactory.Instance.CreateMagazin("Magazin1", "RO325448");

            magazin.AdaugareProdus("Produs1", "1200120455");

            magazin.EditareProdus("Produs1", "ProdusEditat");

            Assert.IsFalse(magazin.Produse.Count(p => p.Denumire.Text == "Produs1")>0);
            Assert.IsTrue(magazin.Produse.Count(p => p.Denumire.Text == "ProdusEditat") > 0);
        }
    }
}
