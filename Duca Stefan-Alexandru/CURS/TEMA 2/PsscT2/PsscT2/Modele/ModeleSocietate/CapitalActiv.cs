using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Modele.ModeleSocietate
{
    class CapitalActiv
    {
       private int numar_actiuni;

        public CapitalActiv(int numar_actiuni)
        {
            this.Numar_actiuni = numar_actiuni;
        }

        public int Numar_actiuni { get => numar_actiuni; set => numar_actiuni = value; }
    }
}
