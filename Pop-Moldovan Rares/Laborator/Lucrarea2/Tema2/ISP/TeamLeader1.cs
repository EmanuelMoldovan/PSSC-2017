using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ISP.Correct
{
    class TeamLeader1 : IWork, IAssign
    {
        public int AssignTask(string taskId, string developerName)
        {
            // assign a task to a developer
            return 1;
        }

        public int WorkOnTask(string taskId)
        {
            // implement a new functionality
            return 1;
        }
    }
}
