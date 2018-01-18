using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Repository;
using WindowsFormsApp1.Models.Entities;


namespace WindowsFormsApp1.Services.AdaugaColetTests
{
    [TestClass()]
    public class AdaugareColetTests
    {
        [TestMethod()]
        public void adaugare_colet_Test_PASS()
        {
            StoreColete.listColete.Add(new Colet("Ion Popescu", "Maria Popescu", "10.03.2017", "01", false, "0.5 kg"));
            Assert.IsNotNull(StoreColete.listColete);
        }
        [TestMethod()]
        public void adaugare_colet_Test_FAIL()
        {
            StoreColete.listColete.Add(new Colet("Ion Popescu", "Maria Popescu", "10.03.2017", "01", false, "0.5 kg"));
            Assert.IsNull(StoreColete.listColete);
        }
        
    }
}