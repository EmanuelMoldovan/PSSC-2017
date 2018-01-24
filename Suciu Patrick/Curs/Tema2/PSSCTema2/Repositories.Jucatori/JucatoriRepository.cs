using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Jucatori
{
    public class JucatoriRepository
    {

        private static List<Modele.Jucatori.Jucatori> jucatori = new List<Modele.Jucatori.Jucatori>();
        public JucatoriRepository()
        {
        }

        public void AdaugaJucator(Modele.Jucatori.Jucatori jucator)
        {
            jucatori.Add(jucator);
        }
        public Modele.Jucatori.Jucatori GasesteJucator(string nume)
        {
            return jucatori.ElementAt(0);

        }
        public List<Modele.Jucatori.Jucatori> get_jucatori()
        {
            return jucatori;
        }
        public int RemoveJucator(string nume)
        {
            int i;
            for (i = 0; i < jucatori.Count; i++)
            {
                if (nume.Equals(jucatori.ElementAt(i).get_nume()))
                {

                    jucatori.RemoveAt(i);

                    return 1;
                }
            }
            return 0;
        }
        public Modele.Jucatori.Jucatori FindJucator(string nume)
        {
            int i;
            for (i = 0; i < jucatori.Count; i++)
            {
                if (nume.Equals(jucatori.ElementAt(i).get_nume()))
                {



                    return jucatori.ElementAt(i);
                }
            }
            return null;
        }
    }
}

