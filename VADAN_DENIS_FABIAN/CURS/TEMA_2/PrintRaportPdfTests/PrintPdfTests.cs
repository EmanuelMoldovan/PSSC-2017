using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintRaportPdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintRaportPdf.Tests
{
    [TestClass()]
    public class PrintPdfTests
    {
        [TestMethod()]
        public void PrintRaportPDFTest()
        {

            PrintPdf pdf = new PrintPdf();

            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = @"d:\raport.pdf";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;


            pdf.PrintRaportPDF();


            Assert.AreEqual(pdf.p.StartInfo, info);
        }
    }
}