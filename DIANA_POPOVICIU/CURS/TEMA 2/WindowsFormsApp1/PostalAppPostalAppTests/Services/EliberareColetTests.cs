using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.Entities;
using WindowsFormsApp1.Repository;


namespace WindowsFormsApp1.Services.TestEliberareColet
{
    [TestClass()]
    public class EliberareColetTests
    {
        [TestMethod()]
        public void eliberare_colet_Test()
        {
            Colet colet_to_del = new Colet();
            StoreColete.listColete.Add(new Colet("Ion Popescu", "Maria Popescu", "10.03.2017", "01", false, "0.5 kg"));
            foreach (Colet colet in StoreColete.listColete)
            {
                if (colet.Numar_inregistrare.CompareTo("01") == 0)
                {
                    colet_to_del = colet;
                }
            }
            StoreColete.listColete.Remove(colet_to_del);
            Assert.IsNull(StoreColete.listColete);
        }
    }
}