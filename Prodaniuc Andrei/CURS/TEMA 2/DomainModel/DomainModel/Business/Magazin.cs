using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Business
{
    public class Magazin
    {
        private List<Produs> _produse;
        public PlainText Nume { get; set; }
        public Adresa Adresa { get; set; }
        public CIF CodIdentificareFiscala { get; set; }
        public ReadOnlyCollection<Produs> Produse { get { return _produse.AsReadOnly(); } }

        public Magazin(string nume, string cif)
        {
            Nume = new PlainText(nume);
            CodIdentificareFiscala = new CIF(cif);
            _produse = new List<Produs>();
        }

        public int NumarProduse()
        {
            var count = Produse.Count;
            return count;
        }

        public int NumarProduse(string denumire)
        {
            var count = Produse.Count(p => p.Denumire.Text == denumire);
            return count;
        }

        public int NumarProduse(CategorieProdus categorie)
        {
            var count = Produse.Count(p => p.Categorie == categorie);
            return count;
        }

        public void AdaugareProdus(string denumire, string codBare)
        {
            Produs produs = new Produs(denumire, codBare);
            _produse.Add(produs);
        }

        public void EditareProdus(string denumire, string denumireNoua)
        {
            var produs = _produse.FirstOrDefault(p=>p.Denumire.Text==denumire);
            produs.Denumire = new PlainText(denumireNoua);
        }
    }
}
