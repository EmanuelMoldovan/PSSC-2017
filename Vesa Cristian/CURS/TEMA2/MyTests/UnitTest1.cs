using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFactory;
namespace MyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreazaBanca()
        {
            var banca = BancaFactory.Instance.creazaBanca("Banca Transilvania");

            Assert.IsNotNull(banca);
        }

        [TestMethod]
        public void createFilialaBanca()
        {
            var filiala = FilialaFactory.Instance.creazaFiliala("Arad,Strada Mihai Eminescu nr.42");

            Assert.IsNotNull(filiala);
        }

        [TestMethod]
        public void creazaAngajat()
        {
            var angajat = EntityFactory.instance.creazaAngajat("Popescu","Ion",null,"strada Florilor nr 30",1000);

            Assert.IsNull(angajat);
        }

        [TestMethod]
        public void creazaClient()
        {
            var client = EntityFactory.instance.CreazaClient("Popescu","Vasile","1962012030032");

            Assert.IsNotNull(client);
        }

        [TestMethod]
        public void creazaCont()
        {
            var cont = EntityFactory.instance.CreazaCont("ROBTRL29312321832",300);

            Assert.IsNotNull(cont);
        }

        [TestMethod]
        public void creazaTranzactie()
        {
            var tranzactie = EntityFactory.instance.creazaTranzactie(Models.Banca.Types.TipTranzactie.Retragere, "ROBTRL29312321832", "10.12.2014",200);

            Assert.IsNotNull(tranzactie);
        }

        [TestMethod]
        public void adaugaBanca()
        {
            var banca = BancaFactory.Instance.creazaBanca("ING");
            var repository = new BancaRepository.BankRepository();

            repository.adaugaBanca(banca);

            Assert.IsNotNull(repository);
        }

    }
}
