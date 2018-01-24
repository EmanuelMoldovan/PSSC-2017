using Modele.Cursanti;
using Modele.Generic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoalaLimbaS.Test
{
    class ModeleTest
    {
        [TestCase(1,"Maria")]
        public void CursantTest(int id, string nume)
        {
            Cursant cursant = new Cursant(id, nume);
            Assert.AreEqual(1, id);
            Assert.AreEqual("Maria", nume);
        }

        [TestCase(15)]
        public void PunctajTest(int punctaj)
        {
            Punctaj punctajTest = new Punctaj(punctaj);
            Assert.AreEqual(15, punctaj);
        }
    }
}
