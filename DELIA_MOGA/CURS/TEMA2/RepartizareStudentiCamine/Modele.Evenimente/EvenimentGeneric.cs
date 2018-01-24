using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Evenimente
{
    public class EvenimentGeneric<T> : Eveniment
    {
        public EvenimentGeneric(T detalii)
            : base(detalii)
        {

        }
    }
}