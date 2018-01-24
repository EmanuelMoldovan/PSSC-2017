using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
    public class Food
    {
        public string _food = string.Empty;
        public string _amount = string.Empty;
        public int _order_nr = 0;
        public Food(string _food, string _amount, int _order_nr)
        {
            this._food = _food;
            this._amount = _amount;
            this._order_nr = _order_nr;
        }
    }
}
