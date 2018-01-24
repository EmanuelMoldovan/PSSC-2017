using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modele.Biblioteca.Entitati;
using ColectiiBiblioteca;
using ServiciiBiblioteca;


namespace Teste
{
    [TestClass]
    public class TestareIntroducereClient
    {
        [TestMethod]
        public void TestMethod1Clienti()
        {
            //pass
            StocareClient.listaClienti.Add(new Client("Mircescu", "Mircea", "12345", 5));
            Assert.IsNull(StocareClient.listaClienti);
        }

        [TestMethod]
        public void TestMethod2Clienti()
        {
            //pass
            AdaugaClient.Adauga_Client();
            Assert.IsNotNull(StocareClient.listaClienti);
        }
    }
}
