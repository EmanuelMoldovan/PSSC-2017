using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSSC.Models.DTO;

namespace PSSC.Models
{
    public class Action
    {
        public Guid Id { get; set; }
        public DateTime DateForAction { get; set; }

        public ActionType _ActionType { get; set; }

        public float Money { get; set; }

       

        public Action(ActionDTO action)
        {
            adaugaAction(action);
        }

        public void adaugaAction(ActionDTO action)
        {
            if (action != null)
            {
                _ActionType = action._ActionType;
                Money = action.Money;
                DateForAction = action.DateForAction;
                Id = action.Id;
            }
            
        }
    }
}
