using NUnit.Framework;
using PsscT2.Modele.ModeleClienti;
using PsscT2.Modele.ModeleSalariati;
using PsscT2.Modele.ModeleSocietate;
using PsscT2.ModelGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Teste
{   
    [TextFixture]
    class TestModele
    {

         [TestCase]
         public void TestSalariati()
        {
            Cont cont = new Cont(10);

            Salariat salariat = new Salariat("salariat1", 55,cont);


            Assert.AreEqual("salariat1", salariat.Nume);
            Assert.AreEqual(55, salariat.Salariu);
            Assert.AreEqual(cont, salariat.Cont);

        }

        [TestCase]
        public void TestClienti()
        {


            Cont cont = new Cont(10);

            Client client = new Client("client1", cont);


            Assert.AreEqual("client1", client.Nume);

            Assert.AreEqual(cont, client.Cont_client);
        }

        [TestCase]
        public void TestSocietate()
        {


            Cont cont_salariat1 = new Cont(10);
            Salariat salariat1 = new Salariat("salariat1", 500, cont_salariat1);

            Cont cont_salariat2 = new Cont(10);
            Salariat salariat2 = new Salariat("salariat2", 650, cont_salariat1);
            Salariati salariati = new Salariati();
            salariati.AdaugaSalariat(salariat1);
            salariati.AdaugaSalariat(salariat2);

            Cont client1cont = new Cont(50);
            Client client1 = new Client("client1", client1cont);

            Cont client2cont = new Cont(50);
            Client client2 = new Client("client2", client2cont);
            Clienti clienti = new Clienti();
            clienti.AdaugaClient(client1);
            clienti.AdaugaClient(client2);
            MijlocFix mijloacefixe = new MijlocFix("sediu", 56656);
            CapitalPasiv capitalpasiv = new CapitalPasiv();
            capitalpasiv.AddMijlocFix(mijloacefixe);
            CapitalActiv capitalactiv = new CapitalActiv(46);
            Cont contsocietate = new Cont(8000);
            FactorySocietate factory = new FactorySocietate();


            Societate societate = factory.CreeazaSocietate("societate", salariati.GetSalariati, clienti.GetClienti, capitalactiv, capitalpasiv, contsocietate, 5);



            Assert.AreEqual("societate",societate.Nume);

            Assert.AreEqual(salariati.GetSalariati, societate.GetSalariati);

            Assert.AreEqual(clienti.GetClienti, societate.Clienti);

            

        }
    }
}
