using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Repository;
using WindowsFormsApp1.Models.Entities;

namespace WindowsFormsApp1.Services.TestEliberareScrisoare
{
    [TestClass()]
    public class EliberareScrisoareTests
    {
        [TestMethod()]
        public void eliberare_scrisoare_Test()
        {
            Scrisoare scrisoare_to_delete = new Scrisoare();
            StoreScrisori.listaScrisori.Add(new Scrisoare("Maria Popescu", "Ion Popescu", "12.03.2017", false));
            foreach (Scrisoare scrisoare in StoreScrisori.listaScrisori)
            {
                if (scrisoare.Destinatar.CompareTo("Maria Popescu") == 0)
                {
                    scrisoare_to_delete = scrisoare;
                }
            }
            StoreScrisori.listaScrisori.Remove(scrisoare_to_delete);
            Assert.IsNull(StoreScrisori.listaScrisori);
        }
    }
}