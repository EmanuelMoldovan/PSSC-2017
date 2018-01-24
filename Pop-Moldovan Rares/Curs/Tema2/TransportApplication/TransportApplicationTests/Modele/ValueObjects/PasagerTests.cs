using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportApplication.Repository;

namespace TransportApplication.Modele.ValueObjects.Tests
{
    [TestClass()]
    public class PasagerTests
    {
        [TestMethod()]
        public void ToStringTest_pasager()
        {
            Pasager pass = new Pasager("Rares Pop-Moldovan");

            Assert.AreEqual(pass.ToString(), "Nume pasager: Rares Pop-Moldovan");
        }

    }
}