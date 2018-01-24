using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generic;
namespace Models.Gradina
{
    public class GradinaFactory
    {
        public static readonly GradinaFactory Instance = new GradinaFactory();

        private GradinaFactory()
        {

        }

        public Gradina CreeazaGradina(int nrLocatie)
        {
            try
            {
                if (nrLocatie < 1 || nrLocatie > 10)
                    throw new ArgumentInvalidException("Dati un nr intre 1 si 10");
                var gradina = new Gradina(nrLocatie);
                return gradina;
            }
            catch(ArgumentInvalidException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
