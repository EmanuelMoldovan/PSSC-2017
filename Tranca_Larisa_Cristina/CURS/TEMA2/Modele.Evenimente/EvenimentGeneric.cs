using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele.Evenimente
{
    public class EvenimentGeneric : Eveniment
    {
        public EvenimentGeneric(object info) : base(info)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
