using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Banca
{
    public interface IBancaRepository<Banca>
    {
        void AdaugaBanca(String n, String a, Boolean Ac);
        void StergeBanca(String NrInregistrare);
    }
}
