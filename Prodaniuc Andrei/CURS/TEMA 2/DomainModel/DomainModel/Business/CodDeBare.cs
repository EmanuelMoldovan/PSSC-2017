using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Business
{
    public class CodDeBare
    {
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public CodDeBare(string value)
        {

        }
    }
}
