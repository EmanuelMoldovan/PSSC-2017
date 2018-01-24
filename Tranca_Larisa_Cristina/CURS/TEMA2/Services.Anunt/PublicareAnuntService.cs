using Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSitePublisher;

namespace Servicii.Disciplina
{
    public class PublicareAnuntService
    {
        public Uri PublicareAnuntPeWebSite(string numeAnunt)
        {
            var repository = new Repositories.Anunt.AnuntRepository();
            var anunt = repository.GasesteAnuntulDupaDescriere(numeAnunt);

            //genereaza continut raport
            var continutRaport = new List<List<string>>();
            foreach (var locuinta in anunt._anunturi)
            {
                var line = new List<string>();
                line.Add(anunt.ToString());
                if (anunt.NumarTelefon != null)
                {
                    line.Add(anunt.NumarTelefon.ToString());
                }
                else
                {
                    line.Add("");
                }

                if (anunt.AdresaEmail != null)
                {
                    line.Add(anunt.AdresaEmail.ToString());
                }
                else
                {
                    line.Add("");
                }

                continutRaport.Add(line);
            }

            //genereaza PDF
            var pdf = new GeneratorRapoartePdf();
            var locatie = pdf.GenerareRaportTabelar(continutRaport);

            //[publica pe OneDrive
            var publisher = new OneDrivePublisher();
            return publisher.PublishToOneDrive(locatie);
        }
    }
}
