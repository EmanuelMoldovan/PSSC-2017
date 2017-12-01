using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class NrCont
    {
        public String NumarCont { get; set; }

        //Idem NrInregistrareBanca
        public NrCont()
        {
            Random random = new Random();
            const string chars = "ABCLMNOPQRSTUVWXYZ01";
            NumarCont = new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
