using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Cont;

namespace Repositories.Conturi
{

    interface RepositoryInterface
    {
        void AdaugaCont(Cont cont);
        void ActualizeazaCont(Cont cont);
    }
}
