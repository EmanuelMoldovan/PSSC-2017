using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Generic;
using Model.Internare;

namespace Repositories.Urgente
{
    public class UrgenteRepository : IUrgenteRepository
    {
        private static List<FisaPacient> _urgente = new List<FisaPacient>();

        public UrgenteRepository()
        {

        }
        public void ActualizeazaUrgenta(FisaPacient fisaPacient)
        {
            throw new NotImplementedException();
        }

        public void AdaugaUrgenta(FisaPacient fisaPacient)
        {
            var result = _urgente.FirstOrDefault(d => d.Equals(fisaPacient));

            if (result != null) throw new DuplicateWaitObjectException();

            _urgente.Add(fisaPacient);
            Console.WriteLine("O noua urgenta a fostr adaugata.");
        }

        public FisaPacient CautaUrgentaDupaCodFisa(PlainText codFisa)
        {
            return _urgente.FirstOrDefault(d => d.CodFisa == codFisa);
        }

        public bool StergeUrgenta(FisaPacient fisaPacient)
        {
            //persit changes to the database
            Console.WriteLine("Urgenta a fost stearsa");
            return true;
        }
    }
}
