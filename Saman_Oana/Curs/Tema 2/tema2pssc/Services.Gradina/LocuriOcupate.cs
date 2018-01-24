using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Gradina
{
    class LocuriOcupate
    {
        public void AfisareGradini()
        {
            var repo = new Repositories.Gradina.GradinaRepository();
            repo.CautaLocuriOcupate();
        }
    }
}
