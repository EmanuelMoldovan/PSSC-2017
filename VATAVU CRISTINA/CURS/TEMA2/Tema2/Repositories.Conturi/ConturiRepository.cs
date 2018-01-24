using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Cont;
using Modele.Generic.Exceptions;

namespace Repositories.Conturi
{
    public class ConturiRepository: RepositoryInterface
    {
        private static List<Cont> listaConturi;
        public List<Cont> getConturi { get { return listaConturi; } }
        public List<Cont> updateConturi { set { listaConturi = value; } }

        public ConturiRepository()
        {
            listaConturi = new List<Cont>();
        }

        public void AdaugaCont(Cont cont)
        {
            Cont result = null;
            foreach (Cont c in listaConturi)
            {
                if (c != null && c.IBAN.getIBAN!=null)
                { 
                    if (c.IBAN.getIBAN.Equals(cont.IBAN.getIBAN))
                    {
                        result = c;
                        break;
                    }
                }
            
            }

            if (result != null) throw new IBANAlreadyExistingException();

            listaConturi.Add(cont);
            Console.WriteLine("Un nou cont adaugat");
        }

        public void ActualizeazaCont(Cont cont)
        {
            //persit changes to the database
            Console.WriteLine("Modificarile au fost salvate.");
        }

    }
}
