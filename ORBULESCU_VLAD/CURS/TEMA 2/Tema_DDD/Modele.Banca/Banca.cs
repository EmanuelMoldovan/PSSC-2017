using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using Modele.Clienti;

namespace Modele.Banca
{
    public class Banca
    {
        public NrInregistrareBanca NrInregistrare { get; set; }
        public String Nume { get; internal set; }
        public String Adresa { get; internal set; }
        public Boolean AcordaCredite { get; set; }
        public float CoeficientDobanda { get; set; }
        public float SumaTotalaRate { get; set; }
        public List<Client> ListaClienti { get; internal set; }

        internal Banca(String n, String a, Boolean Ac)
        {
            NrInregistrare = new NrInregistrareBanca();
            Nume = n;
            Adresa = a;
            AcordaCredite = Ac;
        }

        public override string ToString()
        {
            var acordaCredit = AcordaCredite == true ? "Acorda Credite" : "Nu Acorda Credite";
            return NrInregistrare.ToString() + " " + Nume + " " + Adresa + " " + acordaCredit + 
                " " + CoeficientDobanda.ToString() + " " + ListaClienti.ToString();
        }
    }
}
