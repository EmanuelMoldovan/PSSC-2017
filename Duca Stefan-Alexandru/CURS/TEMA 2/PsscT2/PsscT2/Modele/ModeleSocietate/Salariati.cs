using PsscT2.Modele.ModeleSalariati;
using PsscT2.ModelGeneric;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsscT2.Modele.ModeleSocietate
{
    class Salariati
    {

        private List<Salariat> salariati = new List<Salariat>();        
           

        public  void AdaugaSalariat(Salariat salariat)
        {

            Contract.Requires(salariat != null, "salariat");
            salariati.Add(salariat);
        }
      
        public List<Salariat> GetSalariati
        {
            get { return salariati; }
        }
    }
}
