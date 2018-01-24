using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gradina
{
    public class Pom
    {
        public string nume;
        public int nota;

        public string Nume { get; internal set; }
        public int Nota { get; internal set; }

        internal Pom(string nume, int nota)
        {
            Nume = nume;
            Nota = nota;
        }
        public override string ToString()
        {
            return Nume.ToString();
        }
    }
}
