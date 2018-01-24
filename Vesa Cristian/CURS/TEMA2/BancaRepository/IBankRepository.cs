using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Banca;
namespace BancaRepository
{
    interface IBankRepository
    {
        void adaugaBanca(Banca banca);
        Banca gasesteBanca(string nume);
    }
}
