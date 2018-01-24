using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ISP.Correct
{
    interface IAssign
    {
        int AssignTask(string taskId, string developerName);
    }
}
