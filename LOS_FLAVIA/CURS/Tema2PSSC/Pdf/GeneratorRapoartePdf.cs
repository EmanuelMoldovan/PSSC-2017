using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdf
{
    public class GeneratorRapoartePdf
    {
        
        public void GenerareRaportTabelar(string nume, List<string> continut)
        {
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 10, XFontStyle.Regular);
            XTextFormatter text = new XTextFormatter(graph);
            var x = 0;
            foreach (var linie in continut)
            {
               // Console.WriteLine(x);
               
                text.DrawString(linie, font, XBrushes.Black,
new XRect(0,x, pdfPage.Width.Point, 30), XStringFormats.TopLeft);
                x = x + 60;
               
               
            }
            
            pdf.Save(nume);

        }
    }
}
