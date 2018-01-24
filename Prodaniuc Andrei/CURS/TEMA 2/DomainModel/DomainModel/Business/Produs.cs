using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Business
{
    public class Produs
    {
        public PlainText Denumire { get; set; }
        public CodDeBare CodDeBare { get; set; }
        public CategorieProdus Categorie { get; set; }
        public Pret Pret { get; set; }
        public DataCalendar DataFabricare { get; set; }

        public Produs(string denumire, string codBare)
        {
            Contract.Requires(denumire != null && !string.IsNullOrEmpty(denumire), "message");
            Contract.Requires(codBare != null && !string.IsNullOrEmpty(codBare), "message");
            Denumire = new PlainText(denumire);
            CodDeBare = new CodDeBare(codBare);
        }


        public override bool Equals(object obj)
        {
            var produs = (Produs)obj;
            return produs.Denumire.Equals(this.Denumire)
                && produs.Categorie.Equals(this.Categorie)
                && produs.CodDeBare.Equals(this.CodDeBare)
                && produs.Pret.Equals(this.Pret)
                && produs.DataFabricare.Equals(this.DataFabricare);
        }
        public override string ToString()
        {
            return this.Denumire.ToString() + this.CodDeBare.ToString();
        }
        public override int GetHashCode()
        {
            return this.Denumire.GetHashCode() +
                this.CodDeBare.GetHashCode() +
                this.Pret.GetHashCode() +
                this.DataFabricare.GetHashCode();
        }


    }
}
