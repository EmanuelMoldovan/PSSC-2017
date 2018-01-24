using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportApplication.Modele.Entitati;
using TransportApplication.Repository;
using TransportApplication.Servicii.SeriviciiTransportator;

namespace TransportApplication.Servicii.SeriviciiTransportator.Tests
{
    [TestClass()]
    public class AdaugaTraseuTests
    {
        [TestMethod()]
        public void adauga_traseeTest_adaugareCorectaDate()
        {
            StoreTrasee.listaTrasee.Add(new Traseu("Lugoj", "Arad", "11:00", "13:00"));

            foreach (Traseu tra in StoreTrasee.listaTrasee)
            {
                Assert.AreEqual(tra.LOC_PLECARE, "Lugoj");
                Assert.AreEqual(tra.LOC_SOSIRE, "Arad");
                Assert.AreEqual(tra.ORA_PLECARE, "11:00");
                Assert.AreEqual(tra.ORA_SOSIRE, "13:00");
            }
        }

        [TestMethod()]
        public void adauga_traseeTest_adaugareInCorectaDate()
        {
            StoreTrasee.listaTrasee.Add(new Traseu("Lugoj", "Arad", "11:00", "13:00"));

            foreach (Traseu tra in StoreTrasee.listaTrasee)
            {
                Assert.AreEqual(tra.LOC_PLECARE, "Arad");
                Assert.AreEqual(tra.LOC_SOSIRE, "Arad");
                Assert.AreEqual(tra.ORA_PLECARE, "11:23");
                Assert.AreEqual(tra.ORA_SOSIRE, "13:34");
            }
        }
    }
}