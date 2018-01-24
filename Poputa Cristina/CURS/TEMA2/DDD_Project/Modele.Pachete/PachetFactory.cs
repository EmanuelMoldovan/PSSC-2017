using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Pachete
{
    public class PachetFactory
    {
        public static readonly PachetFactory Instance = new PachetFactory();

        private PachetFactory()
        {

        }

        public Pachet CreazaPachet(string numePachet, int greutate, tip_Pachet tipPachet)
        {
            var pachet = new Pachet(numePachet, greutate, tipPachet);
            return pachet;
        }

       

    }
}
