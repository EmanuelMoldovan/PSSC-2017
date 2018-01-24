using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Echipe
{
  public class EchipeRepository
    {
        private static List<Modele.Echipe.Echipa> echipe = new List<Modele.Echipe.Echipa>();
       
        public EchipeRepository()
        {
        }
        public void AdaugaEchipa(Modele.Echipe.Echipa echipa)
        {
            echipe.Add(echipa);
        }
        public Modele.Echipe.Echipa GasesteEchipa(string nume)
        {

            int i;
            for(i=0;i<echipe.Count;i++)
            {
                if(nume.Equals(echipe.ElementAt(i).get_nume()))
            
                    return echipe.ElementAt(i);
            }
            return null;

        }
        public List<Modele.Echipe.Echipa> get_Echipe()
        {
            return echipe;
        }
        public int RemoveEchipa(string nume,Repositories.Jucatori.JucatoriRepository lista_jucatori)
        {
            int i;
            for (i = 0; i < echipe.Count; i++)
            {
                if (nume.Equals(echipe.ElementAt(i).get_nume()))
                {
                 
                    echipe.RemoveAt(i);

                    return 1;
                }
            }
            return 0;
        }
        public Modele.Echipe.Echipa FindEchipa(string nume)
        {
            int i;
            for (i = 0; i < echipe.Count; i++)
            {
                if (nume.Equals(echipe.ElementAt(i).get_nume()))
                {

                    

                    return echipe.ElementAt(i);
                }
            }
            return null;
        }
    }
}

namespace Modele
{
    class Jucatori
    {
    }
}