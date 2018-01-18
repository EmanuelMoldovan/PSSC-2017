using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PostalApp.Models
{
    [TestClass]
    public class ColetTest
    {
        [TestMethod]
        public void Test_add_colet()
        {
            Colet colet = new Colet("Ion Popescu", "Maria Popescu", "10.03.2017", "01", false, "0.5 kg");
        }
    }
}
