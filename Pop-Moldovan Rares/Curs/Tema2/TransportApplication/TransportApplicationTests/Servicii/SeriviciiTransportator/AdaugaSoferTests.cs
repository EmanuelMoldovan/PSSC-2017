using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportApplication.Modele.Entitati;
using TransportApplication.Repository;
using TransportApplication.Servicii.SeriviciiTransportator;

namespace TransportApplication.Servicii.SeriviciiTransportator.Tests
{
    [TestClass()]
    public class AdaugaSoferTests
    {
        [TestMethod()]
        public void adauga_soferTest_positive()
        {
            StoreSofer.listaSoferi.Add(new Sofer("Ioan Mihalache", "1652332442", 56));
            Assert.IsNotNull(StoreSofer.listaSoferi);
        }

        [TestMethod()]
        public void adauga_soferTest_adaugareCorectaDate()
        {
            StoreSofer.listaSoferi.Add(new Sofer("Igor Petrov", "1702332442", 46));
            foreach (Sofer sofer in StoreSofer.listaSoferi)
            {

                Assert.AreEqual(sofer.NUME_SOFER, "Igor Petrov");
                Assert.AreEqual(sofer.CNP, "1702332442");
                Assert.AreEqual(sofer.VARSTA_SOFER, 46);
            }
        }

    }
}