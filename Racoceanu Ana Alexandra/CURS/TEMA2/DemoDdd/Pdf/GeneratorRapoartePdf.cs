using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pdf
{
    public class GeneratorFacturiPdf
    {
        public string GenerareRaportTabelar(List<List<string>> continut)
        {
            Console.WriteLine("Generare de facturi sub forma de tabel in format PDF.");
            foreach (var linie in continut)
            {
                foreach (var c in linie)
                {
                    Console.Write(c);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            return "c:\factura.pdf";
        }
    }
}
