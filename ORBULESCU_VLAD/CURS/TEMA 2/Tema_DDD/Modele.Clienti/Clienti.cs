using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Clienti
{
    public class Clienti
    {
        //Obiectul ce contine clientii va fi instantiat pe baza repository-ului pentru a putea fi aplicate operatii din servicii
        //ce se opereaza pe o multime de clienti, nu doar pe unul
        public List<Client> _clienti { get; set; }

        public Clienti (List<Client> clienti)
        {
            this._clienti = clienti;
        }

        //Apeleaza pentru fiecare client metoda sa de afisare, aduna intr-o fraza complexa si o returneaza
        public override string ToString()
        {
            var deAfisat = "";
            foreach(Client client in _clienti)
            {
                deAfisat += client.ToString();
            }
            return deAfisat;
        }
    }
}
