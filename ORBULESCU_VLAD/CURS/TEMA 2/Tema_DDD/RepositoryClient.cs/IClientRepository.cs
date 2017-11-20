using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryClient.cs
{
    public interface IClientRepository<Client>
    {
        void AdaugaClient(String N, String P, String Cnp, String Ad, String Em, float Vl, RataCredit Rc);
        void StergeClient(String Cnp);
    }
}
