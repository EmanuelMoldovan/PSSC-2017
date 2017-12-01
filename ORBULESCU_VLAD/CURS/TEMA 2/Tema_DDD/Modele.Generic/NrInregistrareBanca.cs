using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class NrInregistrareBanca
    {
        private string NrInregistrare { get; set; }

        //Apelul 'var exemplu = new NrInregistrare()' va creea un nou nr de inregistrare random
        public NrInregistrareBanca()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            NrInregistrare = new string(Enumerable.Repeat(chars, 16)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
