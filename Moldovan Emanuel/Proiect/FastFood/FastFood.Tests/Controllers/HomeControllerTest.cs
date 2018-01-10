using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastFood;
using FastFood.Controllers;
using FastFood.Domain;
using FastFood.Repositories;

namespace FastFood.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ConnectToDatabase()
        {
            //Arrange
            var model = new Entities();

            //Act
            var categorie = model.Categorii.FirstOrDefault();

            //Assert
            Assert.IsNotNull(categorie);
        }

        [TestMethod]
        public void AddToDatabase()
        {
            //Arrange
            var model = new Entities();
            var categorii = model.Categorii.ToList();
            var initialLength = categorii.Count;

            //Act
            model.Categorii.Add(new Categorie() { Nume = "test", Poza = "poza" });
            model.SaveChanges();

            //Assert
            Assert.AreEqual(initialLength + 1, model.Categorii.ToList().Count);
        }

        [TestMethod]
        public void CreateRepository()
        {
            //Arrange
            var repo = new ProduseRepository();

            //Act && Assert
            Assert.IsNotNull(repo);
        }

        [TestMethod]
        public void GetItemsFromRepository()
        {
            //Arrange
            var repo = new ProduseRepository();

            //Act
            var produse = repo.GetProduse();

            //Assert
            Assert.IsNotNull(produse);
        }

        [TestMethod]
        public void AddProductWithoutPropertiesSetted()
        {
            //Arrange
            var repo = new ProduseRepository();
            var produs = new Produs();

            //Act && Assert
            //Assert.ThrowsException(repo.AdaugaProdus(produs, 1));
        }
    }
}
