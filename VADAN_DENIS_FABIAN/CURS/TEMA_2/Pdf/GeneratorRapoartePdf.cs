using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdf
{
    public class GeneratorRapoartePdf
    {
        public string GenerareRaportTabelar(List<List<string>> continut)
        {
            Console.WriteLine("Generare raport sub forma de tabel in format PDF.");
            foreach (var linie in continut)
            {
                foreach (var c in linie)
                {
                    Console.Write(c);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            return "d:\raport.pdf";
        }
    }
}
