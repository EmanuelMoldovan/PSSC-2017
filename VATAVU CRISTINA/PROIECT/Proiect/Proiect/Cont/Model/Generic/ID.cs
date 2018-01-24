using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class ID
    {
        private int id;
        public int getID{ get { return id; } set { id = value; } }

        public ID(int id)
        {
            this.id = id;
        }
    }
}
