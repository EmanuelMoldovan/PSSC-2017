using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
    class Drinks
    {
        public string _drink = string.Empty;
        public string _amount = string.Empty;
        public int _order_nr = 0;
        public Drinks(string _drink, string _amount, int _order_nr)
        {
            this._drink = _drink;
            this._amount = _amount;
            this._order_nr = _order_nr;
        }
    }
}
