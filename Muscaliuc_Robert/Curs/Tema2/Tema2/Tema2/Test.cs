using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Excursie;
using Repositories.Excursie;
using NUnit.Framework;

namespace Tema2
{
    [TestFixture]
    public class Test
    {
        
        [SetUp]
        public void initializare()
        {
            
        }

        [Test]
        public void verificTipTransport()
        {
            var excursie = ExcursieFactory.Instance.creazaExcursie("Sicilia", 145, "ButterFly");
            //var repo = new ExcursieRepository();
            excursie.seteazaTipTransport("autocar");
            Assert.AreEqual(excursie.transport.TipTransport, "autocar");
        }

        [Test]
        public void verificNumeCazare()
        {
            var excursie = ExcursieFactory.Instance.creazaExcursie("Sicilia", 145, "ButterFly");
            //var repo = new ExcursieRepository();


            Assert.AreEqual(excursie.numeCazare.NumeCazare, "ButterFly");

        }

        //verific numarul de elemente din lista
        [Test]
        public void verificNumarulDeExcursiiDinLista()
        {
            int test = 0;
            var excursie = ExcursieFactory.Instance.creazaExcursie("Sicilia", 145, "ButterFly");      
            var excursie2 = ExcursieFactory.Instance.creazaExcursie("Oslo", 230, "Rooms");

            var repo = new ExcursieRepository();

            repo.adaugaExcursie(excursie);
            repo.adaugaExcursie(excursie2);
            test = repo.numarElementeLista();
            Assert.AreEqual(test, 2);
            
        }
        [Test]
        [Category("fail")]
        public void verificTipPret()
        {
            var excursie = ExcursieFactory.Instance.creazaExcursie("Sicilia", 145, "ButterFly");
            string tip = excursie.seteazaTipPretInEuro();

            Assert.AreEqual(tip, "lei");
        }
    }
}
