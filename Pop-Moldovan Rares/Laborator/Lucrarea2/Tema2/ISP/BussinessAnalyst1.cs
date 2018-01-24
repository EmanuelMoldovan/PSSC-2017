using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ISP.Correct
{
    class BussinessAnalyst1 : IAssign, IClose
    {
        public int AssignTask(string taskId, string developerName)
        {
            // assign a new task to a developer
            return 1;
        }

        public int CloseTask(string taskId)
        {
            // close a task with status done
            return 1;
        }
    }
}
