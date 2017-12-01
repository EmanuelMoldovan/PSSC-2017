using ConsignatieMagazinBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    public class EntityStore
    {
        public static readonly EntityStore instance = new EntityStore();

        public EntityStore() { }

        public Item CreateItem(string Title, string Descriere, decimal Pret, int NumberOfItems,
            bool Duplicate, Furnizor Owner)
        {
            var title = Title;
            var descriere = Descriere;
            var pret = Pret;
            var numberOfItems = NumberOfItems;
            var duplicate = Duplicate;
            var owner = Owner;

            var item = new Item(title, descriere, pret, numberOfItems, duplicate, owner);

            return item;
        }

        public Furnizor CreateFurnizor(string Nume, string Prenume)
        {
            var nume = Nume;
            var prenume = Prenume;

            var furnizor = new Furnizor(nume, prenume);

            return furnizor;
        }

        public Furnizor CreateFurnizorWithPersonalComision(string Nume, string Prenume, double Comision)
        {
            var nume = Nume;
            var prenume = Prenume;
            var comision = Comision;

            var furnizor = new Furnizor(nume, prenume, comision);

            return furnizor;
        }
    }
}
