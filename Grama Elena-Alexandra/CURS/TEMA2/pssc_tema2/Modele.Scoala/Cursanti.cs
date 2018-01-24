using Modele.Cursanti;
using Modele.LimbaStraina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Scoala
{
    public class Cursanti
    {
        public List<Cursant> CursantiLista { get; internal set; }
        public List<NivelLimba> NiveluriLimba { get; internal set; }

        
    }
}
