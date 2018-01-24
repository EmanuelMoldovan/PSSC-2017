using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Spital
{
    public class DateSpital
    {
        public string judet;
        public string localitate;
        public string unitateSanitara;

        public DateSpital(string j, string l, string u)
        {
            judet = j;
            localitate = l;
            unitateSanitara = u;
        }
    }
}
