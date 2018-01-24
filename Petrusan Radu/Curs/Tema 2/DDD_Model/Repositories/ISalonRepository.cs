using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    interface ISalonRepository
    {
        void AdaugaSalon(Salon salon);

        Salon CautaSalon(string nume);

        void ActualizeazaSalon(Salon salon);

        void AdaugaClient(Salon salon, Client client);

        void AdaugaAngajat(Salon salon, Angajat angajat);
    }
}
