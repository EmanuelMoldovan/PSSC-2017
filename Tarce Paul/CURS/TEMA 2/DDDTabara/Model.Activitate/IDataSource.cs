using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;

namespace Modele.Activitate
{
    public interface IDataSource
    {
        TextNume getEchipaCastigatoare();
        TextNume calculPunctajMaxEchipa();
    
        void StartActivitate();
        void StopActivitate();
    }
}
