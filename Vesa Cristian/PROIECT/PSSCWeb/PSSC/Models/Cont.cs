using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSSC.Models.DTO;

namespace PSSC.Models
{
    public class Cont
    {
        public Guid Id { get; set; }

        public string AccountNumber { get; set; }

        public string Currency { get; set; }

        public float MoneyDeposited { get; set; }

        public string User { get; set; }

        public List<Action> ActionList { get; set; }

        public Cont(ContDTO cont)
        {
            adaugaCont(cont);
        }

        private void adaugaCont(ContDTO cont)
        {
            if (cont!=null)
            {
                Id = cont.Id;
                AccountNumber = cont.AccountNumber;
                Currency = cont.Currency;
                MoneyDeposited = cont.MoneyDeposited;
                User = cont.User;
                ActionList = new List<Action>();
            }
        }

        public void adaugaActiune(ActionDTO action)
        {
            Action myAction = new Action(action);
            ActionList.Add(myAction);
        }

        public bool makeTransaction(ActionDTO action)
        {
            if (action._ActionType == ActionType.Deposit)
            {
                return this.deposit(action.Money);
            }
            else {
               return this.withdraw(action.Money);
            }
        }

        private bool deposit(float sum)
        {
            this.MoneyDeposited += sum;
            return true;
        }

        private bool withdraw(float sum)
        {
            if (this.MoneyDeposited >= sum)
            {
                this.MoneyDeposited -= sum;
                return true;
            }
            else
                return false;
        }
    }
}
