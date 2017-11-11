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
    public class FurnizorTests
    {
        [TestMethod()]
        public void FurnizorConstructor()
        {
            Depozit depozit = new Depozit();
            depozit.Furnizori.Add(new ConsignatieMagazinBiblioteca.Furnizor
            { Nume = "TORJE", Prenume = "David", });

            Assert.IsNotNull(depozit); //succes
        }

        [TestMethod()]
        public void toString()
        {
            Furnizor prov = new Furnizor("TORJE", "Timotei");

            Assert.AreEqual(prov.toString, "TORJE Timotei - $0"); //succes
        }
    }
}