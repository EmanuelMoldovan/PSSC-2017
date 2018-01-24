using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Biblioteca.ObiecteValori
{
    public class Orar
    {
        private string OrarInTimpulSapt;
        private string OrarLaSfSapt;

        public Orar(string orarInTimpulSapt, string orarLaSfSapt)
        {
            OrarInTimpulSapt = orarInTimpulSapt;
            OrarLaSfSapt = orarLaSfSapt;
        }

        public string OrarInTimpulSapt1 { get => OrarInTimpulSapt; set => OrarInTimpulSapt = value; }
        public string OrarLaSfSapt1 { get => OrarLaSfSapt; set => OrarLaSfSapt = value; }

        public override bool Equals(object obj)
        {
            var orar = obj as Orar;
            return orar != null &&
                   OrarInTimpulSapt == orar.OrarInTimpulSapt &&
                   OrarLaSfSapt == orar.OrarLaSfSapt;
        }
    }
}
