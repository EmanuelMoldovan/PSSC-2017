using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Pacienti;

namespace Servicii.Pacient
{
    public class CautaPacient
    {
        public int gasit = 0;

        public int Cauta(string cnp)
        {
            foreach (Model.Pacienti.Pacient p in Model.Pacienti.Pacient.listaPacienti)
                if (p.cnp.Equals(cnp))
                    gasit = 1;

            return gasit;
        }

        public Model.Pacienti.Pacient PacientGasit(string cnp)
        {
            Model.Pacienti.Pacient pacientGasit= new Model.Pacienti.Pacient();
            foreach (Model.Pacienti.Pacient p in Model.Pacienti.Pacient.listaPacienti)
                if (p.cnp.Equals(cnp))
                {
                    gasit = 1;
                    pacientGasit = p;
                }

            return pacientGasit;

        }
    }
}
