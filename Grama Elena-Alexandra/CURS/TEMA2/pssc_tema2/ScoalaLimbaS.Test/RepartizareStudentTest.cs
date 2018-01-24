using Modele.LimbaStraina;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoalaLimbaS.Test
{
    [TestFixture]
    public class RepartizareStudentTest

    {
        [Test]
        public void ShouldAddToNivelAList()
        {
            NivelLimba Nivel = new NivelLimba("Engleza", "A1");
            Nivel.RepartizareCursanti("Maria", new Modele.Generic.Punctaj(20));
            int expectedResult=Nivel.nivelLimbaListA.Count();
            Assert.That(expectedResult, Is.EqualTo(1));
        }
        [Test]
        public void ShouldAdd2ToNivelAList()
        {
            NivelLimba Nivel = new NivelLimba("Engleza", "A1");
            Nivel.RepartizareCursanti("Maria", new Modele.Generic.Punctaj(10));
            Nivel.RepartizareCursanti("Ioana", new Modele.Generic.Punctaj(11));
            Nivel.RepartizareCursanti("Maia", new Modele.Generic.Punctaj(89));
            int expectedResult = Nivel.nivelLimbaListA.Count();
            Assert.That(expectedResult, Is.EqualTo(2));
        }
    }
}
