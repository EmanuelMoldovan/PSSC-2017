using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
    class Order
    {
        public string _waiter = string.Empty;
        public string _table = string.Empty;
        public int _order_nr = 0;
        public Order (string _waiter,string _table,int _order_nr)
        {
            this._waiter = _waiter;
            this._table = _table;
            this._order_nr = _order_nr; 
        }
    }
}
