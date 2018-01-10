using FastFood.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Tests
{
    [TestClass]
    class DatabaseTests
    {
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
    }
}
