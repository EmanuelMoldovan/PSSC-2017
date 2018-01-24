using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factories;
using Models.Enums;
using Models;
using Models.Generic;
using Repositories;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CreateAdresa()
        {
            //Arrange & Act
            var adresa = new Adresa(new PlainText("Deva"), new PlainText("Hunedoara"), new PlainText("Mihai Viteazu"), "3a", new CodPostal(new PlainText("330319")));

            Assert.IsNotNull(adresa);
        }

        [TestMethod]
        public void CreateSalon()
        {
            //Arrange
            Salon salon = null;

            //Act
            try
            {
                salon = SalonFactory.Instance.CreazaSalon("Beauty Zone Salon", TipStareSalon.Inchis, null, "RO231293");
            }
            catch { }

            //Assert
            Assert.IsNotNull(salon);
        }

        [TestMethod]
        public void CreateSalonWithNullDescription()
        {
            //Arrange
            Salon salon = null;

            //Act
            try
            {
                salon = SalonFactory.Instance.CreazaSalon(null, TipStareSalon.Deschis, null, "RO12391");
            }
            catch (Exception e)
            {

            }

            //Assert
            Assert.IsNull(salon);
        }

        [TestMethod]
        public void AdaugaSalon()
        {
            //Arrange
            var salon = SalonFactory.Instance.CreazaSalon("Beauty Zone Salon", TipStareSalon.Inchis, null, "RO231293");
            var repository = new SalonRepository();

            //Act
            repository.AdaugaSalon(salon);

            //Assert
            Assert.IsTrue(repository.NumarSaloane() == 1);
        }

        [TestMethod]
        public void AdaugaClient()
        {
            //Arrange
            var client = PersoanaFactory.Instance.CreazaClient("Popescu", "Ion", "1901225201354", TipClient.Fidel);
            var repository = new SalonRepository();
            var salon = repository.CautaSalon("Beauty");

            //Act
            repository.AdaugaClient(salon, client);

            //Assert
            Assert.IsTrue(repository.CautaSalon("Beauty").Clienti.Contains(client));
        }

        [TestMethod]
        public void CautaSalonInexistent()
        {
            //Arrange
            var repository = new SalonRepository();

            //Act
            var salon = repository.CautaSalon("Non-existing salon");

            //Assert
            Assert.IsNull(salon);
        }

        [TestMethod]
        public void CautaSalon()
        {
            //Arrange
            var repository = new SalonRepository();

            //Act
            var salon = repository.CautaSalon("Beauty");

            //Assert
            Assert.IsNotNull(salon);
        }
    }
}