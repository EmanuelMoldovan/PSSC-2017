using Model.Generic;
using Model.ParcAuto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ParcAuto
{
    public class ParcAutoRepository:IParcAutoRepository
    {
        // Model.Generic
        public static List<Model.ParcAuto.Masina> _masini = new List<Model.ParcAuto.Masina>();
        private static List<Model.ParcAuto.ParcAuto> _parc = new List<Model.ParcAuto.ParcAuto>();

        public ParcAutoRepository()
        {

        }

        public void AdaugaMasina(Masina Masina)
        {
            _masini.Add(Masina);
            Console.WriteLine(Masina.ToString());

        }

        public void AdaugaParcAuto(Model.ParcAuto.ParcAuto ParcAuto)
        {
            _parc.Add(ParcAuto);
            Console.WriteLine("Parc auto a fost adaugat!");
        }


        public Masina CautaMasina(string nume)
        {
            return _masini.First(m => m.Marca.ToString().Equals(nume));
          //  throw new NotImplementedException();
        }
    }
}
