using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsignatieMagazinBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignatieMagazinBiblioteca.Tests
{
    [TestClass()]
    public class ItemTests
    {
        [TestMethod()]
        public void ItemConstructor()
        {
            Depozit depozit = new Depozit();
            Furnizor prov = new Furnizor();
            depozit.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Descriere = "A book about a girl",
                Pret = 1.50M,
                NumberOfItems = 7,
                Owner = prov
            });

            Assert.IsNotNull(depozit); //succes
        }

        [TestMethod()]
        public void Display()
        {
            Furnizor prov = new Furnizor();
            Item it = new Item("Jane Eyre", "A book about a girl", 2.2M, 2, false, prov);
            
            Assert.AreEqual(it.Display, "Jane Eyre - $2.2 -> Total: 0"); //succes
        }
    }
}