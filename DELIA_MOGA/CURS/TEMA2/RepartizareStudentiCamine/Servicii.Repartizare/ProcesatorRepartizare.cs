using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.StudentiInscrisi;

namespace Servicii.Repartizare
{
    public class ProcesatorRepartizare
    {
        public void Procesare(ComandaRepartizare comanda)
        {
            var readRepoStud = new ReadRepoStudentiInscrisiCamin();
            var listaStudInscrisi = readRepoStud.ObtineDetaliiStudenti();
            foreach (var student in listaStudInscrisi)
            {
                readRepoStud.Repartizare(student, comanda.Sesiune);
            }
        }
    }
}
