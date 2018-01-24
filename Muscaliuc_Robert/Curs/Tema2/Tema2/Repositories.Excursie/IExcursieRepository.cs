using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Excursie
{
    public interface IExcursieRepository
    {
        void adaugaExcursie(Modele.Excursie.Excursie excursie);
        void afiseazaDetaliiExcursie(string nume);
    }
}
