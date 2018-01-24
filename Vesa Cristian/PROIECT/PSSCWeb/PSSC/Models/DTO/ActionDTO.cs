using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC.Models.DTO
{
    public class ActionDTO
    {
        public Guid Id { get; set; }
        public ActionType _ActionType { get; set; }

        public float Money { get; set; }

        public DateTime DateForAction { get; set; }


        public override string ToString()
        {
            if (_ActionType == ActionType.Deposit)
            {
                return string.Format("{0}:+{1}", DateForAction, Money);
            }
            else if (_ActionType == ActionType.Withdraw)
            {
                return string.Format("{0}:-{1}", DateForAction, Money);
            }
            else return null;
        }
    }
}
