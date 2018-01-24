using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Excursie
{
    public class ExcursieRepository:Repositories.Excursie.IExcursieRepository
    {
        private static List<Modele.Excursie.Excursie> _excursii = new List<Modele.Excursie.Excursie>();
        int sumaElemente = 0;

        public ExcursieRepository()
        {

        }

        public void adaugaExcursie(Modele.Excursie.Excursie excursie){

            _excursii.Add(excursie);
            Console.WriteLine("excursie adaugata");
        }

        public void afiseazaDetaliiExcursie(string nume)
        {

            var detalii = _excursii.Find(x => x.numeCazare.NumeCazare.Equals(nume));
            Console.WriteLine(detalii.numeCazare.NumeCazare);
            Console.WriteLine(detalii.tipPret);
            Console.WriteLine(detalii.transport.TipTransport);

        }

        public int numarElementeLista()
        {
            sumaElemente = _excursii.Count;
            return sumaElemente;
        }

        

    }
}
