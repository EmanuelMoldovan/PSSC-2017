using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modele.Cabinet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Cabinet.Tests
{
    [TestClass()]
    public class CabinetTests
    {
        [TestMethod()]
        public void ProgramarePacientTest()
        {
            Pacient p = new Pacient("a", "b");
            
            Assert.ThrowsException<PacientulExistaExceptions>(() => ProgramarePacient(p));
        }
    }
}