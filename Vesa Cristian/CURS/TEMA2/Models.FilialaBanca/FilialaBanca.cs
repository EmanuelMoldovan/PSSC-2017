using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.FilialaBanca.Entities;
using Models.Generic;
namespace Models.FilialaBanca
{
    public class FilialaBanca
    {
        private PlainText adresa;
        private List<Angajat> angajati;

        public FilialaBanca(PlainText adresa)
        {
            this.adresa = adresa;
            angajati = new List<Angajat>();
        }
        public void adaugaAnagajat(Angajat angajat)
        {
            angajati.Add(angajat);
        }

        public PlainText Adresa { get => adresa; set => adresa = value; }
        public List<Angajat> Angajati { get => angajati; }
        public override bool Equals(object obj)
        {
            var filiala = (FilialaBanca)obj;
            return adresa.Equals(filiala.Adresa);
        }

        public override string ToString()
        {
            return "Filiala:"+adresa.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
