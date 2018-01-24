using Cont.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Proiect.Controllers;
using Proiect.Models;

namespace Teste.MVC
{
    public class Teste
    {
        [Fact]
        public void AfiseazaDateCont()
        {
            var mockReadRepo = new Mock<ReadRepo>();
            var mockWriteRepo = new Mock<WriteRepo>();

            mockReadRepo.Setup(mock => mock.ExistaFisier(It.IsAny<string>())).Returns(true);
            mockReadRepo.Setup(_ => _.CitesteContinutFisier(It.IsAny<string>())).Returns("[{\"IBAN\":\"RO17BCRZ6582043619452916\",\"name\":\"Popescu Ion\",\"sold\":12300.0},{\"IBAN\":\"RO22BACX6548206443372891\",\"name\":\"Anton Maria\",\"sold\":434.5},{\"IBAN\":\"RO55BCRZ6644400075202568\",\"name\":\"Ionescu Matei\",\"sold\":11000.0");

            var controller = new HomeController(mockReadRepo.Object, mockWriteRepo.Object);

            //cum simulez date in casutele de text si o apasare pe buton?

            //var model = (DateCont)(((ActionResult)controller.Index()).Model);
        }

        [Fact]
        public void AfiseazaTranzactii()
        {
            var mockReadRepo = new Mock<ReadRepo>();
            var mockWriteRepo = new Mock<WriteRepo>();

            mockReadRepo.Setup(mock => mock.ExistaFisier(It.IsAny<string>())).Returns(true);
            mockReadRepo.Setup(_ => _.CitesteContinutFisier(It.IsAny<string>())).Returns("[{\"IBAN\":\"RO17BCRZ6582043619452916\",\"name\":\"Popescu Ion\",\"sold\":12300.0},{\"IBAN\":\"RO22BACX6548206443372891\",\"name\":\"Anton Maria\",\"sold\":434.5},{\"IBAN\":\"RO55BCRZ6644400075202568\",\"name\":\"Ionescu Matei\",\"sold\":11000.0");

            var controller = new HomeController(mockReadRepo.Object, mockWriteRepo.Object);

            //cum simulez date in casutele de text si o apasare pe buton?
        }
    }
}
