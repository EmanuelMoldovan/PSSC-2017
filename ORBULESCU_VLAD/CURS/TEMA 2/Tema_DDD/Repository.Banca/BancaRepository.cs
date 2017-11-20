using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Banca;
namespace Repository.Banca
{
    public class BancaRepository : IBancaRepository<Modele.Banca.Banca>
    {
        private List<Modele.Banca.Banca> _banci;
        public void AdaugaBanca(String n, String a, Boolean Ac)
        {
            Modele.Banca.Banca bancaNoua = BancaFactory.CreeazaBanca(n, a, Ac);
            var exists = _banci.Any(x => x.NrInregistrare.ToString() == bancaNoua.NrInregistrare.ToString());
            if(exists)
            {
                throw new NrInregistrareBancaDuplicat(bancaNoua.NrInregistrare);
            }
            else
            {
                _banci.Add(bancaNoua);
            }
        }

        public void StergeBanca(String NrInregistrare)
        {
            _banci = _banci.Where(x => x.NrInregistrare.ToString() != NrInregistrare).ToList();
        }

        //TODO - Implement GET
        public Modele.Banca.Banca GetBanca(string NrInreg)
        {

        }
    }
}
