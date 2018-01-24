using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modele.Biblioteca.Entitati;
using ColectiiBiblioteca;
using ServiciiBiblioteca;
using Modele.Biblioteca.ObiecteValori;


namespace Teste
{
    [TestClass]
    public class TestareOrarBiblioteca
    {
        Orar orar = new Orar("08:00-20:00", "10:00-16:00");
        string data1 = "08:00-20:00";
        string data2 = "10:00-16:00";
        string data3 = "10:01-16:00";

        [TestMethod]
        public void TestMethodOrar1()
        {
            //pass
            Assert.AreEqual(orar.OrarInTimpulSapt1, data1);
            Assert.AreEqual(orar.OrarLaSfSapt1, data2); 
        }

        [TestMethod]
        public void TestMethodOrar2()
        {   
            //fail
            Assert.AreEqual(orar.OrarInTimpulSapt1, data1);
            Assert.AreEqual(orar.OrarLaSfSapt1, data3);
        }

        [TestMethod]
        public void TestMethodOrar3()
        {
            //fail
            Assert.AreNotEqual(orar.OrarInTimpulSapt1, data1);
            Assert.AreEqual(orar.OrarLaSfSapt1, data2);
        }

    }
}
