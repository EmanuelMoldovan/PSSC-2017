using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Biblioteca.Entitati
{
    public class Angajat
    {
        private string id;
        private string nume;
        private string prenume;
        private string functie;

        public Angajat(string id, string nume, string prenume, string functie)
        {
            this.Id = id;
            this.Nume = nume;
            this.Prenume = prenume;
            this.Functie = functie;
        }

        public string Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public string Functie { get => functie; set => functie = value; }

        public override bool Equals(object obj)
        {
            var angajat = obj as Angajat;
            return angajat != null &&
                   Id == angajat.Id &&
                   Nume == angajat.Nume &&
                   Prenume == angajat.Prenume &&
                   Functie == angajat.Functie;
        }
    }
}
