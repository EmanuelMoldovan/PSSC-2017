using System;
using System.Collections.Generic;
using System.Text;
using Modele.Generic;

namespace Modele.ClasaStudiu
{
    public class Elev
    {
        public NumarMatricol NumarMatricol { get; internal set; }
        public PlainText Nume { get; internal set; }
       // public Materie materie { get; internal set; }
        public Nota NotaMaterie { get; internal set; }
        public string Materie;

        public Elev(NumarMatricol nrMatricol, PlainText nume, Nota nota, string materie )
        {
            NumarMatricol = nrMatricol;
            Nume = nume;
            NotaMaterie = nota;
            Materie = materie;
        }
    }
}
