using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ISP.Correct
{
    class Developer1 : IWork
    {
        public int WorkOnTask(string taskId)
        {
            // implement a new functionality
            return 1;
        }
    }
}
