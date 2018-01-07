using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoDdd;
using Repositories.Etaj;
using Modele.Etaj;
using Servicii.Disciplina;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var etaj = EtajFactory.Instance.CreeazaEtaj("40");
            var repository = new EtajRepository();
            repository.AdaugaEtaj(etaj);

            // testam ca etajul adaugat exista
            Etaj e1 = repository.GasesteEtajulDupaNumar("40");
            Assert.IsNotNull(e1);

            Oaspete o1 = EtajFactory.Instance.CreeazaOaspete(12345678901, "Andrei");
            etaj.RezervareOaspeti(o1);

            etaj.IncepeSezonul();

            etaj.inchidereSezon();

            // testam faptul ca s-a emis factura la finalul sezonului
            Assert.IsNotNull(o1.getNotaDePlata());
            
            repository.ActualizeazaEtaj(etaj);
        }
    }
}
