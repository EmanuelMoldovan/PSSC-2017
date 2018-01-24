using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorPDF;
using Model.Pacienti;

namespace Model.FisePacient
{
    public class IstoricPacient
    {
        public Pacient pacient;
        
        public void GenerareFisa(Pacient pacient, string path)
        {

            var generator = new GenerarePDFDate(pacient, path, "istoric");

        }
    }
}
