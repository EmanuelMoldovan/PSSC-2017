using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Activitate;

namespace Repositories.Activitate
{
    interface IActivitateRepository
    {
        void AdaugaActivitate(Modele.Activitate.Activitate activitate);
        void GasesteActivitate(string nume);
    }
}
