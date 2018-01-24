using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
   public class CalculatePeriod
    {
        DateTime now= DateTime.Now.ToLocalTime();
        DateTime start;
        private string start_date;

        public CalculatePeriod(string start_date)
        {
            this.start_date = start_date;
        }

        public int period()
        {
            start= Convert.ToDateTime(start_date);
            int i = 1;
            now = now.AddDays(-i);
            while (DateTime.Compare(now,start) >=0)
            {
                i++;
                now = now.AddDays(-i);
            }
            return i;
        }
        
    }
}
