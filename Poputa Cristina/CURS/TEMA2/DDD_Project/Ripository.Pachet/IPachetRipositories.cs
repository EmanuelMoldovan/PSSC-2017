using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripository.Pachet
{
    interface IPachetRipositories
    {
        void AdaugaPachet(Modele.Pachete.Pachet pachet);
        void ActualizeazaPachet(Modele.Pachete.Pachet pachet);
        Modele.Pachete.Pachet GasestePachetDupaNume(string nume);
    }
}
