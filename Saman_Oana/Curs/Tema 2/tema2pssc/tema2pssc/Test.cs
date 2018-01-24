using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generic;
using Models.Gradina;
using Repositories.Gradina;
using Services.Gradina;
using NUnit.Framework;

namespace tema2pssc
{
    class Test
    {
        [Test]
        [Category("pass")]
        public void VerificaGradinaLocatiePass()
        {
            //arrange
            var gradina = GradinaFactory.Instance.CreeazaGradina(1);

            //act
            var locatie = gradina.nrLocatie;

            //assert
            Assert.AreEqual(1, locatie);
        }

        [Test]
        [Category("fail")]
        public void VerificaGradinaLocatieFail()
        {
            //arrange
            var gradina = GradinaFactory.Instance.CreeazaGradina(0);

            //act
            var locatie = gradina.nrLocatie;

            //assert
            Assert.AreEqual(0, locatie);
        }

        [Test]
        [Category("pass")]
        public void VerificaCasaEsteDragutaPass()
        {
            //arrange
            var gradina = GradinaFactory.Instance.CreeazaGradina(1);
            gradina.AdaugaFloare("Garoafa", "Galben", 12);

            //act
            gradina.DecoreazaCasaCuFlori("Garoafa", 3);

            //assert
            Assert.IsTrue(gradina.casaEsteDraguta);

        }

        [Test]
        [Category("fail")]
        public void VerificaCasaEsteDragutaFail()
        {
            //arrange
            var gradina = GradinaFactory.Instance.CreeazaGradina(1);
            gradina.AdaugaFloare("Garoafa", "Galben", 12);

            //act
            gradina.DecoreazaCasaCuFlori("Garoafa", 13);

            //assert
            Assert.IsTrue(gradina.casaEsteDraguta);
        }

        [Test]
        [Category("pass")]
        public void VerificaGradinaCountEsteZero()
        {
            //arrange
            var gradina = GradinaFactory.Instance.CreeazaGradina(1);

            //act
            //adaugat 11 plante - ar trebui sa se adauge doar 10 pt ca
            //doar atatea locuri sunt in gradina
            gradina.AdaugaFloare("Garoafa", "Galben", 12);
            gradina.AdaugaFloare("Lalea", "Rosie", 1);
            gradina.AdaugaFloare("Lacramioara", "Alba", 10);

            gradina.AdaugaLeguma("Morcov", TipLeguma.Radacina, 1);
            gradina.AdaugaLeguma("Telina", TipLeguma.Radacina, 12);
            gradina.AdaugaLeguma("Ceapa", TipLeguma.Bulb, 10);

            gradina.AdaugaPom("Mar", 10);
            gradina.AdaugaPom("Par", 8);
            gradina.AdaugaPom("Cires", 5);
            gradina.AdaugaPom("Piersic", 9);
            gradina.AdaugaPom("Gutui", 10);

            //assert
            Assert.AreEqual(0, gradina.locuriGradina);
        }
    }
}
