using Modele.Clienti;
using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryClient.cs
{
    //Acest repository este completat si modificat o data cu obiectul din clasa Clienti
    //in acest fel avand posibilitatea de a efectua operatii direct pe un obiect cu mai multi clienti sau pe un singur client (clasa Client)
    public class ClientiRepository : IClientRepository<Client>
    {
        private Clienti _clienti;

        public void AdaugaClient(String N, String P, String Cnp, String Ad, String Em, float Vl, RataCredit Rc)
        {
            Client clientNou = ClientFactory.CreeazaClient(N, P, Cnp, Ad, Em, Vl, Rc);
            var exists = _clienti._clienti.Any(x => x.Cnp == clientNou.Cnp);
            if (exists)
            {
                throw new CnpDuplicat(clientNou.Cnp);
            }
            else
            {
                _clienti._clienti.Add(clientNou);
                
            }

        }

        public void StergeClient(string Cnp)
        {
            _clienti._clienti = _clienti._clienti.Where(x => x.Cnp == Cnp).ToList();
        }
    }
}
