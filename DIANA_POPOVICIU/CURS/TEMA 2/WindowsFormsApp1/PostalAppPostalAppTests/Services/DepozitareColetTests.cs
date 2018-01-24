using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.Entities;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Services.TestDepozitareColet
{
    [TestClass()]
    public class DepozitareColetTests
    {
        [TestMethod()]
        public void deopzitare_colet_Test()
        {
            StoreColete.listColete.Add(new Colet("Ion Popescu", "Maria Popescu", "10.03.2017", "01", false, "0.5 kg"));
            foreach (Colet colet in StoreColete.listColete)
            {
                if (colet.Destinatar.CompareTo("01") == 0)
                {
                    colet.Depozitat = true;
                }
            }

        }
    }
}