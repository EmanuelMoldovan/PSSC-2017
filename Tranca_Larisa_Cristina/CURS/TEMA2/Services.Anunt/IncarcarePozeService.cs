using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSitePublisher;

namespace Servicii.Disciplina
{
    public class IncarcarePozeService
    {

        public void IncarcarePoze(string descriere, int numarPoze, string locatieContinut)
        {
            //apeleaza infrastructura pentru upload
            var publisher = new OneDrivePublisher();
            var uri = publisher.PublishToOneDrive(locatieContinut);

            //actualizeaza modelul
            var repository = new Repositories.Anunt.AnuntRepository();
            var anunt = repository.GasesteAnuntulDupaDescriere(descriere);
            anunt.IncarcarePoze(numarPoze, uri);

        }

    }
}
