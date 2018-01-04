using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IDataCaster<T>
    {
        List<T> CastObjectListToTypeList(List<Object> list);
        List<object> CastTypeListToObjectList(List<T> list);
    }
}
