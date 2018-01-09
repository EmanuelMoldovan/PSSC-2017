using FastFood.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastFood.Repositories
{
    public class CategoriiRepository
    {
        public void AdaugaCategorie(Categorie categorie)
        {
            using (var model = new Entities())
            {
                model.Categorii.Add(categorie);
                model.SaveChanges();
            }
        }

        public List<Categorie> GetCategorii()
        {
            using (var model = new Entities())
            {
                return model.Categorii.Include("Produs").ToList();
            }
        }

        public Categorie GetCategorie(int id)
        {
            using (var model = new Entities())
            {
                return model.Categorii.Include("Produs").Where(w => w.Id == id).FirstOrDefault();
            }
        }
    }
}