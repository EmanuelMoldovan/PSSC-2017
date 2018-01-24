using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Camin;
using Modele.Camin.DTO;
using Repositories.Camin;

namespace Servicii.StopInscrieri
{
    public class ProcesatorStopInscrieri
    {
        public void Procesare(ComandaStopInscrieri comanda)
        {
            var repo = new WriteRepoCamin();
            SesiuneInscrieriCaminDTO gasit = repo.GasesteSesiune(comanda.Sesiune);
            SesiuneInscrieriCamin sesiuneStop = new SesiuneInscrieriCamin(gasit);
            sesiuneStop.Stop();
        }
    }
}
