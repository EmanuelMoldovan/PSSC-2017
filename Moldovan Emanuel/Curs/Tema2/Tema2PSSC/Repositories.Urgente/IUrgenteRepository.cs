using Model.Generic;
using Model.Internare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Urgente
{
    interface IUrgenteRepository
    {
        void AdaugaUrgenta(FisaPacient fisaPacient);
        FisaPacient CautaUrgentaDupaCodFisa(PlainText codFisa);
        void ActualizeazaUrgenta(FisaPacient fisaPacient);
        bool StergeUrgenta(FisaPacient fisaPacient);
    }
}
