using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ParcAuto
{
    interface IParcAutoRepository
    {
        Model.ParcAuto.Masina CautaMasina(string nume);
        void AdaugaParcAuto(Model.ParcAuto.ParcAuto ParcAuto);

        void AdaugaMasina(Model.ParcAuto.Masina Masina);
    }
}
