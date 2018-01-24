using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MagazinElectronice
{
    public class MagazinElectronice
    {

        public string adresa { get; internal set; }
        public string nume { get; internal set; }
        public int nrAngajati { get; internal set; }


        public ListaLaptopuri laptop { get; internal set; }
        public ListaTelefoane telefoane { get; internal set; }
        public ListaTelevizoare televizoare { get; internal set; }



        public MagazinElectronice(string nume, string adresa, int nrAngajati)
        {
            Contract.Requires(adresa != null, "Magazinul trebuie sa aiba adresa");

            this.adresa = adresa;
            Contract.Requires(nume != null, "Magazinul trebuie sa aiba nume");

            this.nume = nume;

            this.nrAngajati = nrAngajati;
            laptop = new ListaLaptopuri();
            telefoane = new ListaTelefoane();
            televizoare = new ListaTelevizoare();
        }

        public MagazinElectronice(string nume)
        {
            Contract.Requires(nume != "", "Magazinul trebuie sa aiba nume");
            this.nume = nume;
            laptop = new ListaLaptopuri();
            telefoane = new ListaTelefoane();
            televizoare = new ListaTelevizoare();
        }
        public void AdaugaProdus(Object produs)
        {
            if (produs is Laptop)
            {
                laptop.adaugaLaptop((Laptop)produs);
            }
            else if (produs is Telefon)
            {
                telefoane.adaugaTelefon((Telefon)produs);
            }
            else
            {
                televizoare.adaugaTelevizor((Televizor)produs);
            }
        }

        public void VindeProdus(Object produs)
        {
            if (produs is Laptop)
            {
                laptop.stergeLaptop((Laptop)produs);
            }
            else if (produs is Telefon)
            {
                telefoane.stergeTelefon((Telefon)produs);
            }
            else
            {
                televizoare.stergeTV((Televizor)produs);
            }
        }

        public Object AfisareProdusDupaNume(TipProdus type, string nume)
        {
            if (type == TipProdus.Laptop)
            {
                var lap = laptop.ListaLaptop.Find(laptop => laptop.firma.Equals(nume));
                return lap;
            }
            else if (type == TipProdus.Telefon)
            {
                var tel = telefoane.ListaTElefon.Find(telefon=> telefon.firma.Equals(nume));
                return tel;
            }
            else
            {
                var tv = televizoare.Televizoare.Find(TV => TV.Firma.Equals(nume));
                return tv;
            }
        }

    }
}
