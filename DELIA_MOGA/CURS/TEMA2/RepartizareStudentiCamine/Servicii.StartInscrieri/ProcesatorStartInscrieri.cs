using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Camin;
using Modele.Camin.DTO;
using Repositories.Camin;

namespace Servicii.StartInscrieri
{
    public class ProcesatorStartInscrieri
    {
        public void Procesare(ComandaStartInscrieri comanda)
        {
            var repo = new WriteRepoCamin();
            SesiuneInscrieriCaminDTO gasit = repo.GasesteSesiune(comanda.Sesiune);
            SesiuneInscrieriCamin sesiuneStart = new SesiuneInscrieriCamin(gasit);
            sesiuneStart.Start();
        }
    }
}
