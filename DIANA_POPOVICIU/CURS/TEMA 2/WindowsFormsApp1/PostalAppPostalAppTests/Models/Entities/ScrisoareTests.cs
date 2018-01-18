using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Entities.ScrisoareTests
{
    [TestClass()]
    public class ScrisoareTests
    {
        [TestMethod()]
        public void ScrisoareTest()
        {
            Scrisoare newScrisoare = new Scrisoare("Maria Popescu", "Ion Popescu", "12.03.2017", true);

            Assert.AreEqual(newScrisoare.Destinatar, "Maria Popescu");
            Assert.AreEqual(newScrisoare.Expeditor, "Ion Popescu");
            Assert.AreEqual(newScrisoare.Data_sosire, "12.03.2017");
            Assert.AreEqual(newScrisoare.Recomandata, true);
        }
    }
}