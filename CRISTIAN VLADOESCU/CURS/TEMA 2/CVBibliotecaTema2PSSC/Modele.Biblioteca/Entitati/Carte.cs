using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Biblioteca.Entitati
{
    public class Carte
    {
        private string Domeniu;
        private string Autor;
        private string Titlu;
        private string idCarte;
        private int nrExemplare;
        private string termenReturnare;

        public Carte(string domeniu, string autor, string titlu, string idCarte, int nrExemplare, string termenReturnare)
        {
            Domeniu1 = domeniu;
            Autor1 = autor;
            Titlu1 = titlu;
            this.IdCarte = idCarte;
            this.NrExemplare = nrExemplare;
            this.TermenReturnare = termenReturnare;
        }

        public string Domeniu1 { get => Domeniu; set => Domeniu = value; }
        public string Autor1 { get => Autor; set => Autor = value; }
        public string Titlu1 { get => Titlu; set => Titlu = value; }
        public string IdCarte { get => idCarte; set => idCarte = value; }
        public int NrExemplare { get => nrExemplare; set => nrExemplare = value; }
        public string TermenReturnare { get => termenReturnare; set => termenReturnare = value; }

        public override bool Equals(object obj)
        {
            var carte = obj as Carte;
            return carte != null &&
                   Domeniu1 == carte.Domeniu1 &&
                   Autor1 == carte.Autor1 &&
                   Titlu1 == carte.Titlu1 &&
                   IdCarte == carte.IdCarte &&
                   NrExemplare == carte.NrExemplare &&
                   TermenReturnare == carte.TermenReturnare;
        }
    }
}
