using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Evenimente
{
    public class Eveniment
    {
        public Guid Id { get; private set; }
        public object Detalii { get; private set; }

        public Eveniment(object detalii)
        {
            Detalii = detalii;
            Id = Guid.NewGuid();
        }
    }
}
