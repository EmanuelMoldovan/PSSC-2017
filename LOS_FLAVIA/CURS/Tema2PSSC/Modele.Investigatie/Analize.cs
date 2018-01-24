using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Investigatie
{
   public class Analize
    {
        int Hemoglobina { get; set; }
        int Leucocite { get; set; }
        int Trigliceride { get; set; }

        public Analize(int hem, int leu, int tri)
        {
            Hemoglobina = hem;
            Leucocite = leu;
            Trigliceride = tri;

        }
        public override string ToString()
        {
            return "\nTrigliceride:"+Trigliceride.ToString() + "\nLeucocite" + Leucocite+"\nHemoglobina"+Hemoglobina+"\n";
        }

       
    
}
}
