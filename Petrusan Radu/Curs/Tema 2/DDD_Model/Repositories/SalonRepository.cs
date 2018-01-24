using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
    public class SalonRepository : ISalonRepository
    {
        private static List<Salon> _saloane = new List<Salon>();

        public void ActualizeazaSalon(Salon salon)
        {
            throw new NotImplementedException();
        }

        public void AdaugaAngajat(Salon salon, Angajat angajat)
        {
            var salonRepository = CautaSalon(salon.Denumire.Text);

            if (salonRepository != null)
            {
                salonRepository.Angajati.Add(angajat);
            }
        }

        public void AdaugaClient(Salon salon, Client client)
        {
            var salonRepository = CautaSalon(salon.Denumire.Text);

            if (salonRepository != null)
            {
                salonRepository.Clienti.Add(client);
            }
        }

        public void AdaugaSalon(Salon salon)
        {
            var result = _saloane.FirstOrDefault(s => s.Equals(salon));

            if (result != null)
            {
                throw new Exception("Exista deja acest salon!");
            }

            _saloane.Add(salon);
        }

        public Salon CautaSalon(string nume)
        {
            return _saloane.FirstOrDefault(s => s.Denumire.Text.StartsWith(nume));
        }

        public int NumarSaloane()
        {
            return _saloane.Count;
        }
    }
}
