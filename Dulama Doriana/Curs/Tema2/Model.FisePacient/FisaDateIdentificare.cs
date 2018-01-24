using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorPDF;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Model.Pacienti;
using SharedData;

namespace Model.FisePacient
{
    public class FisaDateIdentificare
    {
        public void GenerareFisa(Pacient pacient, string path)
        {
            var generator = new GenerarePDFDate(pacient,path, "date identificare");       
        }
    }
}
