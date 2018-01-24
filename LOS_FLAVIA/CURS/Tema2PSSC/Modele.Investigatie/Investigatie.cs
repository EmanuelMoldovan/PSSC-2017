using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Investigatie
{
    public class Investigatie
    {
        public string Cnp { get; set; }
        public Analize Analize { get; set; }

      

        public Investigatie(string cnp, Analize analize)
        {
           
            Contract.Requires(analize != null, "analize");
            Contract.Requires(cnp != null, "cnp");
            Cnp = cnp;           
            Analize = analize;
        }
        public override string ToString()
        {
            return Cnp.ToString() + "\nAnalize:" + Analize.ToString();
        }

        public override bool Equals(object obj)
        {
            var inv = (Investigatie)obj;

            if (inv != null)
            {
                return Cnp.Equals(inv.Cnp);
            }
            return false;
        }

    }
}

