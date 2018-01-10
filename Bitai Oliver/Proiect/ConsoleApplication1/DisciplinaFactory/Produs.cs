using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisciplinaFactory
{
    public class Produs
    {
        public string Nume;
        public double Pret;
        public string Cantitate;
        public DateTime DataExpirari;
        public int NrBucati;

        internal Produs(Produs p)
        {
            this.Nume = p.Nume;
            this.Pret = p.Pret;
            this.Cantitate = p.Cantitate;
            this.DataExpirari = p.DataExpirari;
            this.NrBucati = p.NrBucati;
        }
        internal Produs(string Nume, double Pret, string Cantitate, DateTime Data,int Bucati)
        {
            this.Nume = Nume;
            this.Pret = Pret;
            this.Cantitate = Cantitate;
            this.DataExpirari = Data;
            this.NrBucati = Bucati;
        }
        public override string ToString()
        {
            return "  Nume: " + Nume.ToString() + "\n" + "   Pret: " + Pret.ToString() +" lei" + "\n" +
                "   Cantitate: " + Cantitate.ToString() + "\n" + "   Data Expirari: " +
                DataExpirari.ToShortDateString() + "\n" + "   Numar Bucati: " + NrBucati.ToString() + "\n\n";
        }
    }
}
