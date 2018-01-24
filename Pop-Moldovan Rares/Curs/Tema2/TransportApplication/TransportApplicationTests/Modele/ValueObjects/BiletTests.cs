using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TransportApplication.Modele.ValueObjects.Tests
{
    [TestClass()]
    public class BiletTests
    {
        [TestMethod()]
        public void ToStringTest_bilet()
        {
            Bilet bilet = new Bilet("Arad","10:00","Timisoara","11:00");
            Assert.AreEqual(bilet.ToString(),"Arad " + "Timisoara " + "10:00 " + "11:00");
        }
    }
}