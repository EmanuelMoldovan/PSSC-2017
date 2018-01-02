using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Identity_and_access_Layer.Models
{
    public class Client : User
    {
        public String Nume;
        public String Prenume;
        public int Varsta;
        public float TotalPlata;
        internal static IRoleMapper roleMapper;

       public Client(Guid id, String u, String p, int roleNo, String n, String pr, int v, float tp) : base(id,u,p,roleNo,roleMapper)
        {
            Nume = n;
            Prenume = pr;
            Varsta = v;
            TotalPlata = tp;
        }
    }
}
