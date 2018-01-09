using FastFood.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastFood.Repositories
{
    public class ProduseRepository
    {
        public ProduseRepository()
        {
                           
        }

        public void AdaugaProdus(Produs produs, int idCategorie)
        {
            using (var model = new Entities())
            {
                var categorie = model.Categorii.FirstOrDefault(c => c.Id == idCategorie);

                categorie.Produs.Add(produs);
                produs.Categorie = categorie;

                model.Produse.Add(produs);
                model.SaveChanges();
            }
        }

        public List<Produs> GetProduse()
        {
            using (var model = new Entities())
            {
                return model.Produse.Include("Categorie").ToList();
            }
        }

        public Produs GetProdus(int id)
        {
            using (var model = new Entities())
            {
                return model.Produse.Include("Categorie").Where(w => w.Id == id).FirstOrDefault();
            }
        }

        public List<Produs> GetProduseCategorie(Categorie categorie)
        {
            using (var model = new Entities())
            {
                return model.Produse.Include("Categorie").Where(p => p.Categorie.Nume == categorie.Nume).ToList();
            }
        }
    }
}