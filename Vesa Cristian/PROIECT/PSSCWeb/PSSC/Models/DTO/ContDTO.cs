using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC.Models.DTO
{
    public class ContDTO
    {
        public Guid Id { get; set; }

        public string AccountNumber { get; set; }

        public string Currency { get; set; }

        public float MoneyDeposited { get; set; }

        public string User { get; set; }

        public List<ActionDTO> ActionList { get; set; }
        public override string ToString()
        {
            return string.Format("{0}-{1}{2}",AccountNumber,MoneyDeposited,Currency);
        }
    }
}
