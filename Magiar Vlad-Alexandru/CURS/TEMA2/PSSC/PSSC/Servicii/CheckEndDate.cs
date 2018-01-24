using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
    public class CheckEndDate
    {
        private string end_date;

        public CheckEndDate(string end_date)
        {
            End_date = end_date;
        }

        public string End_date { get => end_date; set => end_date = value; }

        public int Check()
        {
            DateTime data = Convert.ToDateTime(End_date);
            data = data.AddDays(1);
            DateTime now = DateTime.Now.ToLocalTime();
            if ((DateTime.Compare(now, data) < 1))
                return 1;
            else
                return -1;
        }
    }
}
