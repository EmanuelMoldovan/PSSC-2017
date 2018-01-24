using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
    class GetXmlData
    {
        public string _waiter = string.Empty;
        public string _order_no = string.Empty;
        public string _table = string.Empty;
        public string _order = string.Empty;
        public string _amount = string.Empty;
        public GetXmlData(string _waiter,string _order_no,string _table, string _order, string _amount)
        {
            this._waiter = _waiter;
            this._order_no = _order_no;
            this._table = _table;
            this._order = _order;
            this._amount = _amount;
        }
    }
}
