using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Meci;

namespace Repositories.Meci
{
    public class MeciRepository
    {
        public static List<Modele.Meci.Meci> _meci = new List<Modele.Meci.Meci>(); 

        public void AdaugaMeci(Modele.Meci.Meci meci)
        {
            var result = _meci.FirstOrDefault(d => d.Equals(meci));

            if (result != null) throw new DuplicateWaitObjectException();

            _meci.Add(meci);
            Console.WriteLine("Un nou meci adaugat");
        }

    }
}
