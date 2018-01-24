using Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicii.Disciplina
{
    public class PublicareRaportPlata
    {
        public PublicareRaportPlata(string numeHotel, string numarEtaj)
        {
      
        }
    
        public Uri PublicareNotePeWebSite(string numarEtaj)
        {
            var repository = new Repositories.Etaj.EtajRepository();
            var etaj = repository.GasesteEtajulDupaNumar(numarEtaj);

           
            var continutRaport = new List<List<string>>();
            foreach (var oaspete in etaj.RezervariOaspeti)
            {
                var oaspeti = new List<string>();
                oaspeti.Add(oaspete.ToString());
                if (oaspete.NotaDePlataFinala != 0)
                {
                    oaspeti.Add(oaspete.NotaDePlataFinala.ToString());
                }
                else
                {
                    oaspeti.Add("");
                }

                continutRaport.Add(oaspeti);
            }

            var pdf = new GeneratorFacturiPdf();
            var locatie = pdf.GenerareRaportTabelar(continutRaport);

            return new Uri("http://google.com");
        }
    }
}
