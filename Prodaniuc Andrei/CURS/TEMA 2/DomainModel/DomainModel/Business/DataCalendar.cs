using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Business
{
    public class DataCalendar
    {
        private DateTime _value;
        public DateTime Value
        {
            get { return _value; }
            private set {}
        }

        public DataCalendar(DateTime value)
        {
            Contract.Requires(value!=null, "message");
            Value = value;
        }

        public override bool Equals(object obj)
        {
            var date = (DataCalendar)obj;
            return date.Value.Equals(this.Value);
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
