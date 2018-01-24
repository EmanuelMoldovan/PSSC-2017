using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele.Evenimente
{
    public class Eveniment
    {
        public Guid Id { get; private set; }
        public object Info { get; private set; }

        public Eveniment(object info)
        {
            Info = info;
            Id = Guid.NewGuid();
        }
}
}
