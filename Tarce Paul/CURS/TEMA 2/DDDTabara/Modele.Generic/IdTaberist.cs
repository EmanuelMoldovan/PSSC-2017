using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Modele.Generic
{
    public class IdTaberist
    {
        private string _id;
        public string Id { get { return _id; } }
        public IdTaberist(string id)
        {
            Contract.Requires<ArgumentNullException>(id != null, "id e null");
            Contract.Requires<ArgumentException>(id.Length == 4, "Id-ul are 4 caractere");

            _id = id;
        }
    }
}
