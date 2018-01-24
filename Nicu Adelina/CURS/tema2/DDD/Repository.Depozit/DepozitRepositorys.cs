using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Depozit
{
    public class DepozitRepositorys
    {
        private static List<Modele.Depozit.Depozit> _depozit = new List<Modele.Depozit.Depozit>();
       
        public void AdaugaDepozit(Modele.Depozit.Depozit depozit)
        {
            var result = _depozit.FirstOrDefault(d => d.Equals(depozit));

            if (result != null) throw new DuplicateWaitObjectException();

            _depozit.Add(depozit);
            Console.WriteLine("Un nou depozit a fost adaugat.");
        }

        public void ActualizeazaDepozit(Modele.Depozit.Depozit depozit)
        {
            //persit changes to the database
            Console.WriteLine("Modificarile au fost salvate.");
        }

        public Modele.Depozit.Depozit GasesteDepozitulDupaNume(string nume)
        {
            return _depozit.FirstOrDefault(d => d.nume == nume);
        }  
    }
}
