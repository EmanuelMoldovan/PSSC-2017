using Pdf;
using System;
using System.Collections.Generic;

namespace Servicii.Disciplina
{
    public class PrintareRaport
    {
        public void PrintRaportPdf(string numeCabinet)
        {
            var repository = new Repositories.Cabinet.CabinetRepository();
            var cabinet = repository.GasesteDCabinetDupaNume(numeCabinet);

            //genereaza continut raport
            var continutRaport = new List<List<string>>();
            foreach (var pacient in cabinet.PacientiProgramati)
            {
                var line = new List<string>();
                line.Add(pacient.ToString());
                if (pacient.PretFinal != null)
                {
                    line.Add(pacient.PretFinal.ToString());
                }
                else
                {
                    line.Add("");
                }
                continutRaport.Add(line);
            }

            //genereaza PDF
            var pdf = new GeneratorRapoartePdf();
            var locatie = pdf.PrintRaportPdf(continutRaport);
        }
    }
}
