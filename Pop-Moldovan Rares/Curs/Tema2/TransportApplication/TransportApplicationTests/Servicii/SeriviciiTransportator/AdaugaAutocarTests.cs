using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportApplication.Modele.Entitati;
using TransportApplication.Repository;
using TransportApplication.Servicii.SeriviciiTransportator;


namespace TransportApplication.Servicii.SeriviciiTransportator.Tests
{
    [TestClass()]
    public class AdaugaAutocarTests
    {
        [TestMethod()]
        public void adauga_autocareTest_positive()
        {
            StoreAutocar.listaAutocare.Add(new Autocar("Mercedes-Benz", "A233", "AR-91-CLG", "2004"));
            Assert.IsNotNull(StoreAutocar.listaAutocare);
        }

        [TestMethod()]
        public void adauga_autocareTest_negative()
        {
            StoreAutocar.listaAutocare.Add(new Autocar("Mercedes-Benz", "A233", "AR-91-CLG", "2004"));
            Assert.IsNull(StoreAutocar.listaAutocare);
        }
    }
}