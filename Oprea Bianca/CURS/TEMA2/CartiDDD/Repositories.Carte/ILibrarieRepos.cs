using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using Modele.Librarie;

namespace Repositories.Lib
{
    interface ILibrarieRepos
    {
        void Adauga_librarie(Librarie librarie);
        void Actualizeaza_librarie(Librarie librarie);
        string Inchide_librarie(Text nume);
    }
}
