using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Ambulanta
{
    public class Ambulanta
    {
        public string Marca { get; internal set; }
        public int An { get; internal set; }
        public NumarMasina NumarInmatriculare { get; internal set; }

        public Ambulanta(string marca, int an, NumarMasina numarInmatriculare)
        {
            Contract.Requires(marca != null, "dati marca");
            Contract.Requires(an >2000 , "dati anul masinii");
            Contract.Requires(an < 2018, "dati anul masinii");
            Contract.Requires(numarInmatriculare!=null, "dati numar inmatriculare");

            Marca = marca;
            An = an;
            NumarInmatriculare = numarInmatriculare;
        }

        public override string ToString()
        {
            return NumarInmatriculare.ToString()+" marca "+Marca.ToString()+" din anul "+ An+"\n\n" ;
        }

        public override bool Equals(object obj)
        {
            var ambulanta = (Ambulanta)obj;

            if (ambulanta != null)
            {
                return NumarInmatriculare.Equals(ambulanta.NumarInmatriculare);
            }
            return false;
        }

    }
}
