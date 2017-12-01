using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Client;
using Model.ParcAuto;
using Repository.ParcAuto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ParcAuto.Tests
{
    [TestClass()]
    public class ParcAutoFactoryTests
    {
        [TestMethod()]
        public void VerifyIfParcAutoConstructorWorks()
        {
            var parcAuto = ParcAutoFactory.Instance.CreeazaParcAuto("Autoklass", "Timisoara", "Timis", "Soarelui", 102);
            Assert.AreEqual(parcAuto.Nume.Text,"Autoklass");
            Assert.AreEqual(parcAuto.Adresa.Localitate.Text, "Timis");
            Assert.AreEqual(parcAuto.Adresa.Judet.Text, "Timisoara");
            Assert.AreEqual(parcAuto.Adresa.Strada.Text, "Soarelui");
            Assert.AreEqual(parcAuto.Adresa.Numar, 102);
        }

        [TestMethod()]
        public void VerifyIfMasinaConstructorWorks()
        {
            var masina = ParcAutoFactory.Instance.CreeazaMasina(Model.ParcAuto.TipMasina.Break, "WV Golf", "2003", "230k", "nu bate nu trocane");
            Assert.AreEqual(masina.Tip,Model.ParcAuto.TipMasina.Break);
            Assert.AreEqual(masina.Marca.Text, "WV Golf");
            Assert.AreEqual(masina.An.Text, "2003");
            Assert.AreEqual(masina.kilometraj.Text, "230k");
            Assert.AreEqual(masina.Descriere.Text, "nu bate nu trocane");
        }

        [TestMethod()]
        public void VerifyIfParcAutoDealerWorks()
        {
           
            var dealer = ParcAutoFactory.Instance.CreeazaDealer("Popescu", "Emil", "19203022993");
            Assert.AreEqual(dealer.Nume.Text,"Popescu");
            Assert.AreEqual(dealer.Prenume.Text, "Emil");
            Assert.AreEqual(dealer.CNP, "19203022993");
        }

        [TestMethod()]
        public void VerifyIfCautaMasinaWorks()
        {
            var repository = new ParcAutoRepository();
            var masina = ParcAutoFactory.Instance.CreeazaMasina(Model.ParcAuto.TipMasina.Break, "WV Golf", "2003", "230k", "nu bate nu trocane");
            repository.AdaugaMasina(masina);
            Assert.AreEqual(repository.CautaMasina("WV Golf").Marca.Text, masina.Marca.Text);
        }

        [TestMethod()]
        public void VerifiIfCleintConstructorWorks()
        {
            var client = ClientFactory.Instance.CreeazaClient("Nagy", "Andrei", "19503180222222");
            Assert.AreEqual(client.Nume.Text,"Nagy");
            Assert.AreEqual(client.Prenume.Text, "Andrei");
            Assert.AreEqual(client.CNP, "19503180222222");
        }
    }
}