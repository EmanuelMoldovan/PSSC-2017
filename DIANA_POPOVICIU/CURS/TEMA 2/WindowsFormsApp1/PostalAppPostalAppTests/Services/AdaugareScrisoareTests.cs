using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Repository;
using WindowsFormsApp1.Models.Entities;

namespace WindowsFormsApp1.Services.AdaugaScrisoareTests
{
    [TestClass()]
    public class AdaugareScrisoareTests
    {
        [TestMethod()]
        public void adaugare_scrisoare_Test_PASS()
        {
            StoreScrisori.listaScrisori.Add(new Scrisoare("Maria Popescu", "Ion Popescu", "12.03.2017", false));
            Assert.IsNotNull(StoreScrisori.listaScrisori);
        }
        [TestMethod()]
        public void adaugare_scrisoare_Test_FAIL()
        {
            StoreScrisori.listaScrisori.Add(new Scrisoare("Maria Popescu", "Ion Popescu", "12.03.2017", false));
            Assert.IsNull(StoreScrisori.listaScrisori);
        }
    }
}