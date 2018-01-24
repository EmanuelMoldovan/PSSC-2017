using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gradina
{
    public class Leguma
    {
        public string nume;
        public TipLeguma tip;
        public int numar;

        public string Nume { get; internal set; }
        public TipLeguma Tip { get; internal set; }
        public int Numar { get; internal set; }

        internal Leguma(string nume, TipLeguma tip, int numar)
        {
            Nume = nume;
            Tip = tip;
            Numar = numar;
        }
        public override string ToString()
        {
            return Nume.ToString();
        }
    }
}
