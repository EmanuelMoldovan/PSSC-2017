using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Banca;

namespace BancaRepository
{
    public class BankRepository: BancaRepository.IBankRepository
    {
        private static List<Banca> banci = new List<Banca>();

        public BankRepository() { }

        public void adaugaBanca(Banca banca)
        {
            var result = banci.FirstOrDefault(d => d.Equals(banca));

            if (result != null) throw new DuplicateWaitObjectException();

            banci.Add(banca);
            Console.WriteLine("O noua banca a fost adaugata.");
        }

        public Banca gasesteBanca(string nume)
        {
            return banci.FirstOrDefault(d => d.ToString() == nume);
        }
    }

}
