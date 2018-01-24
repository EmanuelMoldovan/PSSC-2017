using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColectiiBiblioteca;
using Modele.Biblioteca.Entitati;

namespace Teste
{
    [TestClass]
    public class TestareIntroducereAngajat
    {
        [TestMethod]
        public void TestMethod1Angajati()
        {
            //pass
            StocareAngajat.listaAngajati.Add(new Angajat("Id01", "Popescu", "Ion", "Administrator"));
            foreach (Angajat angajat in StocareAngajat.listaAngajati)
            {
                Assert.AreEqual(angajat.Id, "Id01");
                Assert.AreEqual(angajat.Nume, "Popescu");
                Assert.AreEqual(angajat.Prenume, "Ion");
                Assert.AreEqual(angajat.Functie, "Administrator");
            }
        }

        [TestMethod]
        public void TestMethod2Angajati()
        {
            //fail
            StocareAngajat.listaAngajati.Add(new Angajat("Id02", "Popescu", "Ion", "Administrator"));
            foreach (Angajat angajat in StocareAngajat.listaAngajati)
            {
                Assert.AreEqual(angajat.Id, "Id01");
                Assert.AreEqual(angajat.Nume, "Popescu");
                Assert.AreEqual(angajat.Prenume, "Ion");
                Assert.AreEqual(angajat.Functie, "Administrator");
            }
        }
    }
}
