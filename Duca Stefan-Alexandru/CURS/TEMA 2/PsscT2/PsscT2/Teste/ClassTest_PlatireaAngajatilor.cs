using NUnit.Framework;
using PsscT2.Modele.ModeleSalariati;
using PsscT2.Modele.ModeleSocietate;
using PsscT2.ModelGeneric;
using PsscT2.Servicii.SocietateServicii;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Teste
{   
    [TestFixture]
    class ClassTest_PlatireaAngajatilor
    {
        private double falgException=0;

        [TestCase]
        public void PositiveTest_PlatesteAngajati()
        {

            Cont contfirma = new Cont(50);
            Cont contAngajat = new Cont(30);
            Salariat salariat = new Salariat("popescu", 15, contAngajat);
            Salariati salariati = new Salariati();
            salariati.AdaugaSalariat(salariat);
            PlatesteAngajat plateste_angajat = new PlatesteAngajat();


            plateste_angajat.PlatesteAngajati(contfirma, salariati.GetSalariati);

            Assert.AreEqual(45, contAngajat.GetBalance());

        }


        [TestCase]
        public void NegativeTest_PlatesteAngajati()
        {

            Cont contfirma = new Cont(50);
            Cont contAngajat = new Cont(30);
            Salariat salariat = new Salariat("popescu", 60, contAngajat);
            Salariati salariati = new Salariati();
            salariati.AdaugaSalariat(salariat);
            PlatesteAngajat plateste_angajat = new PlatesteAngajat();

            //act
            try
            {
                plateste_angajat.PlatesteAngajati(contfirma, salariati.GetSalariati);

            } catch (NotFundsException)
            {
                falgException = 1;
            }

            //asert
            Assert.AreEqual(1, falgException);


        }

    }
}
