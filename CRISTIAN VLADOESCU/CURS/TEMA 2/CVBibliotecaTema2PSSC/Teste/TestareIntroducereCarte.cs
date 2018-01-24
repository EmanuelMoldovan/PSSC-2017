using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modele.Biblioteca.Entitati;
using ColectiiBiblioteca;
using ServiciiBiblioteca;

namespace Teste
{
    [TestClass]
    public class TestareIntroducereCarte
    {
        [TestMethod]
        public void TestMethodCarte1()
        {
            //fail
            AdaugaCarte.adauga_carte();
            Assert.IsNull(StocareCarte.listaCarti);
        }

        [TestMethod]
        public void TestMethodCarte2()
        {
            //pass
            AdaugaCarte.adauga_carte();
            Assert.IsNotNull(StocareCarte.listaCarti);
        }

        [TestMethod]
        public void TestMethodCarte3()
        {
            //pass
            Carte carte = new Carte("literatura", "X", "Y", "xx01", 25, "o saptamana");
            Assert.AreEqual(carte.NrExemplare,25);
        }

        [TestMethod]
        public void TestMethodCarte4()
        {
            //fail
            Carte carte = new Carte("literatura", "X", "Y", "xx01", 35, "o saptamana");
            Assert.AreEqual(carte.NrExemplare, 25);
        }
    }
}
