using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Entities.Tests
{
    [TestClass()]
    public class ColetTests
    {
        [TestMethod()]
        public void ColetTest()
        {
            Colet newColet = new Colet("Ion Popescu", "Maria Popescu", "10.03.2017", "01", false, "0.5 kg");

            Assert.AreEqual(newColet.Destinatar, "Ion Popescu");
            Assert.AreEqual(newColet.Expeditor, "Maria Popescu");
            Assert.AreEqual(newColet.Data_sosire, "10.03.2017");
            Assert.AreEqual(newColet.Numar_inregistrare, "01");
            Assert.AreEqual(newColet.Greutate, "0.5 kg");
            Assert.AreEqual(newColet.Depozitat, false);





        }
    }
}