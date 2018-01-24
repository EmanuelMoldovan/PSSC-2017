using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Meci;
using WebSitePublisher;
using Repositories.Meci;

namespace Servicii.Meci
{
    public class AdaugareMeci
    {
        public void IncarcaMeci(string locatie)
        {
            var publisher = new OneDrivePublisher();
            var uri = publisher.PublishToOneDrive(locatie);

            var repository = new Repositories.Meci.MeciRepository();
        }
    }
}
